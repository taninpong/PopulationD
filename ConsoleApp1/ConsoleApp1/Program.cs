using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
//using WebManageAPI.Function;
using MongoDB.Driver;
using Newtonsoft.Json;
using NsoGetData.Models;
using NSOWater.HotMigration.HotModels;
using NSOWater.HotMigration.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


namespace NsoGetData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Blob To Json V 0.0.1";
            var now = DateTimeOffset.UtcNow;
            int count = 0;
            string data = "11002061000110";
            var itemBlob_Building = new List<CloudBlockBlob>();
            var itemBlob_House = new List<CloudBlockBlob>();
            var blddataAll = new List<BldData2>();
            var blddata = new List<BldData>();
            var untdata = new List<UntData>();
            var untdata2 = new UntData();
            var sumbldunt = new List<SumBldUnt>();
            //var itemBlob_Community = new List<CloudBlockBlob>();
            //Nso Real

            var client = new MongoClient("mongodb://dbagent:Nso4Passw0rd5@mongodbproykgte5e7lvm7y-vm0.southeastasia.cloudapp.azure.com/nso");
            var database = client.GetDatabase("nso");
            // Nso Dev
            //var client = new MongoClient("mongodb://thesdev:Th35Passw0rd5@thes-dev-db.onmana.app/nso2");
            //var database = client.GetDatabase("nso2");
            var collection = database.GetCollection<SurveyData>("survey");

            var storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=nsostorage;AccountKey=Lzw/JGZTvtHoRxo8GKjWQy5rm3vprPahD4YsoRXhi7Ai+Gyg34tq+Y+HrEuNf5SOAib1jNNavkFVghaKk/488w==;EndpointSuffix=core.windows.net");
            var blobClient = storageAccount.CreateCloudBlobClient();
            //var container = blobClient.GetContainerReference("surveys");

            //BlobContinuationToken blobContinuationToken = null;

            Console.Write($"Province Code : ");
            string provincecode = Console.ReadLine();

            Console.WriteLine("Please Wait........");

            var uploadLogs = collection.Aggregate()
                .Match(x => x.Province == provincecode)
                .Match(y => y.Enlisted == true)
                .ToList();
            string pathbuilding = @"d:\\Nsodata_building.txt";
            string pathhouseHold = @"d:\\Nsodata_houseHold.txt";
            string pathCommunity = @"d:\\Nsodata_poppulationjson.txt";
            string pathCommunity2 = @"d:\\Nsodata_poppulationtxt.csv";

            Console.WriteLine($"Total data = { uploadLogs.Count }");
            var r = 0;
            DateTime Now = DateTime.Now;

            foreach (var log in uploadLogs)
            {
                r++;
                Console.WriteLine($"[{ Now }] {r}{"/"}{uploadLogs.Count} : Success !!");

                var directory = blobClient.GetContainerReference(log.ContainerName);
                //var directory = container.GetDirectoryReference(log.Province).GetDirectoryReference(log.SrcUserId).GetDirectoryReference(log.ContainerName);
                var blob = directory.GetBlockBlobReference(log.BlobName);
                if (log.BlobName.StartsWith("bld"))
                {
                    itemBlob_Building.Add(blob);
                }
                else if (log.BlobName.StartsWith("unt"))
                {
                    itemBlob_House.Add(blob);
                }
                var created = directory.CreateIfNotExistsAsync();
                var containerName = directory.Name;
                var sas = directory.GetSharedAccessSignature(new SharedAccessBlobPolicy()
                {
                    Permissions = SharedAccessBlobPermissions.Read,
                    SharedAccessStartTime = now.AddMinutes(-5),
                    SharedAccessExpiryTime = now.AddMinutes(1200),

                });
            }
            ////เขียน list ลง text
            Console.WriteLine("building..");
            //writer.Write("[");

            foreach (var item in itemBlob_Building)
            {
                count++;
                var building = ReadModelBlob<BuildingSample>(item).GetAwaiter().GetResult();
                blddataAll.Add(new BldData2()
                {
                    _id = building._id,
                    EA = building.EA,
                    Ordering = building.Ordering,
                    Road = building.Road,
                    Alley = building.Alley,
                    Name = building.Name,
                    HouseNo = building.HouseNo,
                    Latitude = building.Latitude,
                    Longitude = building.Longitude,
                    BuildingType = building.BuildingType,
                    Other = building.Other,
                    Accesses = building.Accesses,
                    VacancyCount = building.VacancyCount,
                    AbandonedCount = building.AbandonedCount,
                    UnitCount = building.UnitCount,
                    UnitAccess = building.UnitAccess,
                    VacantRoomCount = building.VacantRoomCount,
                    OccupiedRoomCount = building.OccupiedRoomCount,

                });
                Console.WriteLine($"[{ Now }] {count}{"/"}{uploadLogs.Count} : Success !!");
            }
            using (StreamWriter writer = new StreamWriter(pathbuilding, false))
            {
                //writer.Write(blddataAll.ToJson());
            }

            Console.WriteLine("houseHold..");
            foreach (var blobHH in itemBlob_House)
            {
                //var count2 = 1;
                count++;
                var houseHold = ReadModelBlob<HouseHoldSample>(blobHH).GetAwaiter().GetResult();
                if (houseHold.Population.PersonCount > 0)
                {
                    foreach (var item in houseHold.Population.Persons)
                    {

                        var persondata = new Poppulation();
                        persondata.FirstName = item.FirstName;
                        persondata.LastName = item.LastName;
                        persondata.NameTitle = item.NameTitle.Value;
                        persondata.Relationship = item.Relationship;
                        persondata.Sex = item.Sex;
                        persondata.OtherTitle = item.OtherTitle;
                        persondata.BirthDate = item.BirthDate;
                        persondata.BirthMonth = item.BirthMonth;
                        persondata.BirthYear = item.BirthYear;
                        persondata.Age = item.Age;
                        persondata.Nationality = item.Nationality;
                        persondata.Registration = item.Registration;
                        persondata.OtherProvince = item.OtherProvince;
                        untdata.Add(new UntData
                        {
                            BuildingId = houseHold.BuildingId,
                            UntID = houseHold._id,
                            Personcount = houseHold.Population.PersonCount,
                            Skip = houseHold.Population.Skip,
                            PoppulationData = persondata,
                            AllPersonCount = houseHold.Population.AllPersonCount,
                            femalePerson = houseHold.Population.FemalePerson,
                            malePerson = houseHold.Population.MalePerson
                        });
                        Console.WriteLine($"[{ Now }] {count}{"/"}{uploadLogs.Count} : Success !!");
                    }
                }
                else if (houseHold.Population.PersonCount == null)
                {
                    Console.WriteLine($"[{ Now }] {count}{"/"}{uploadLogs.Count} : Success !!");
                    continue;
                }
                else if (houseHold.Population.PersonCount == 0)
                {
                    var persondata = new Poppulation();
                    persondata.FirstName = "";
                    persondata.LastName = "";
                    persondata.NameTitle = null;
                    persondata.Relationship = null;
                    persondata.Sex = null;
                    persondata.OtherTitle = "";
                    persondata.BirthDate = null;
                    persondata.BirthMonth = null;
                    persondata.BirthYear = null;
                    persondata.Age = null;
                    persondata.Nationality = "";
                    persondata.Registration = null;
                    persondata.OtherProvince = "";
                    untdata.Add(new UntData
                    {
                        BuildingId = houseHold.BuildingId,
                        UntID = houseHold._id,
                        Personcount = houseHold.Population.PersonCount,
                        Skip = houseHold.Population.Skip,
                        PoppulationData = persondata,
                        AllPersonCount = houseHold.Population.AllPersonCount,
                        femalePerson = houseHold.Population.FemalePerson,
                        malePerson = houseHold.Population.MalePerson
                    });
                    Console.WriteLine($"[{ Now }] {count}{"/"}{uploadLogs.Count} : Success !!");
                }
            }
            using (StreamWriter writer = new StreamWriter(pathhouseHold, false))
            {
                //writer.Write(untdata.ToJson());
            }
            //Console.WriteLine(untdata.Count);

            Console.WriteLine("SumBldUnt..");
            var count2 = 1;
            var sumc = blddataAll.Count + untdata.Count;
            for (int i = 0; i < blddataAll.Count; i++)
            {
                for (int j = 0; j < untdata.Count; j++)
                {
                    if (blddataAll[i]._id == untdata[j].BuildingId)
                    {
                        sumbldunt.Add(new SumBldUnt()
                        {
                            BldData = new BldData
                            {
                                EA = blddataAll[i].EA,
                                Road = blddataAll[i].Road,
                                Alley = blddataAll[i].Alley,
                                BuildingType = blddataAll[i].BuildingType,
                                HouseNo = blddataAll[i].HouseNo,
                                Name = blddataAll[i].Name,
                                Ordering = blddataAll[i].Ordering,
                                _id = blddataAll[i]._id
                            },
                            UntData = new UntData
                            {
                                AllPersonCount = untdata[j].AllPersonCount,
                                BuildingId = untdata[j].BuildingId,
                                femalePerson = untdata[j].femalePerson,
                                malePerson = untdata[j].malePerson,
                                Personcount = untdata[j].Personcount,
                                PoppulationData = untdata[j].PoppulationData,
                                Skip = untdata[j].Skip,
                                UntID = untdata[j].UntID
                            }
                            //untdata[j]
                        });
                        Console.WriteLine($"[{ Now }] {count2}{"/"}{sumc} : Success !!");
                        count2++;
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(pathCommunity, false))
            {
                //writer.Write(sumbldunt.ToJson());
            }

            using (StreamWriter writer = new StreamWriter(pathCommunity2, false))
            {
                //writer.WriteLine("Bld_Id,Bld_EA,Bld_Ordering,Bld_Road,Bld_Alley,Bld_Name,Bld_HouseNo,Bld_BuildingType,Unt_BuildingId,Unt_Poppulation_NameTitle,Unt_Poppulation_OtherTitle,Unt_Poppulation_FirstName,Unt_Poppulation_LastName,Unt_Poppulation_Relationship,Unt_Poppulation_Sex,Unt_Poppulation_BirthDate,Unt_Poppulation_BirthMonth,Unt_Poppulation_BirthYear,Unt_Poppulation_Age,Unt_Poppulation_Nationality,Unt_Poppulation_Registration,Unt_Poppulation_OtherProvince");
                writer.WriteLine("Bld_Id" +
                    ",Bld_EA" +
                    ",Bld_Ordering" +
                    ",Bld_Road" +
                    ",Bld_Alley" +
                    ",Bld_Name" +
                    ",Bld_HouseNo" +
                    ",Bld_BuildingType" +
                    ",UntID" +
                    ",Skip" +
                    ",Personcount" +
                    ",allPersonCount" +
                    ",malePerson" +
                    ",femalePerson" +
                    ",Unt_Poppulation_NameTitle" +
                    ",Unt_Poppulation_OtherTitle" +
                    ",Unt_Poppulation_FirstName" +
                    ",Unt_Poppulation_LastName" +
                    ",Unt_Poppulation_Relationship" +
                    ",Unt_Poppulation_Sex" +
                    ",Unt_Poppulation_BirthDate" +
                    ",Unt_Poppulation_BirthMonth" +
                    ",Unt_Poppulation_BirthYear" +
                    ",Unt_Poppulation_Age" +
                    ",Unt_Poppulation_Nationality" +
                    ",Unt_Poppulation_Registration" +
                    ",Unt_Poppulation_OtherProvince");

                foreach (var item in sumbldunt)
                {
                    writer.Write(item.BldData._id + ","
                        + item.BldData.EA.ToString() + ","
                        + item.BldData.Ordering.ToString() + ","
                        + item.BldData.Road + ","
                        + item.BldData.Alley + ","
                        + item.BldData.Name + ","
                        + item.BldData.HouseNo + ","
                        + (int)item.BldData.BuildingType + ","
                        + item.UntData.UntID + ","
                        + item.UntData.Skip.ToString() + ","
                        + item.UntData.Personcount + ","
                        + item.UntData.AllPersonCount + ","
                        + item.UntData.malePerson + ","
                        + item.UntData.femalePerson + ","
                        + item.UntData.PoppulationData.NameTitle + ","
                        + item.UntData.PoppulationData.OtherTitle + ","
                        + item.UntData.PoppulationData.FirstName + ","
                        + item.UntData.PoppulationData.LastName + ","
                        + item.UntData.PoppulationData.Relationship + ","
                        + item.UntData.PoppulationData.Sex + ","
                        + item.UntData.PoppulationData.BirthDate + ","
                        + item.UntData.PoppulationData.BirthMonth + ","
                        + item.UntData.PoppulationData.BirthYear + ","
                        + item.UntData.PoppulationData.Age + ","
                        + item.UntData.PoppulationData.Nationality + ","
                        + item.UntData.PoppulationData.Registration + ","
                        + item.UntData.PoppulationData.OtherProvince
                        );
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Download Success! Enter TO Exits Program");
            string provincecode3 = Console.ReadLine();

        }

        private static async Task<T> ReadModelBlob<T>(CloudBlockBlob blob)
        {
            var blobContent = await blob.DownloadTextAsync();
            var model = JsonConvert.DeserializeObject<T>(blobContent);
            return model;
        }


    }

}
