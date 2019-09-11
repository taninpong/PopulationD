using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class HasWarningMessage
    {
        public bool HasWarningMsg(HouseHoldSampleSpecial unit)
        {
            return unit != null && (unit.Residence?.MemberCount > 20
             || checkAgriculture(unit.Agriculture)
             || unit.Factory?.WorkersCount > 100
             || checkCommerce(unit.Commerce)
             || checkWaterUsage(unit.WaterUsage)
             || checkDisaster(unit.Disaster)
            );
        }

        private bool checkAgriculture(Agriculture agr)
        {
            return agr != null && agr.RicePlant?.FieldCount > 20
                || agr.RicePlant?.FieldCount > 20
                || checkFields(agr.RicePlant?.Fields)
                || agr.AgronomyPlant?.FieldCount > 20
                || checkFields(agr.AgronomyPlant?.Fields)
                || agr.RubberTree?.FieldCount > 20
                || checkFields(agr.RubberTree?.Fields)
                || agr.PerennialPlant?.FieldCount > 20
                || checkFields(agr.PerennialPlant?.Fields)
                || agr.HerbsPlant?.FieldCount > 20
                || checkFields(agr.HerbsPlant?.Fields)
                || agr.FlowerCrop?.FieldCount > 20
                || checkFields(agr.FlowerCrop?.Fields)
                || agr.MushroomPlant?.FieldCount > 20
                || checkAnimal(agr.AnimalFarm)
                || checkAquaticAnimal(agr.AquaticAnimals)
                ;
        }

        private bool checkFields(List<RicePlantingField> fields)
        {
            return fields != null && fields
            .Any(it => it.Area?.Rai > 50
            || it.PlantingCount > 20
            || it.AreaUsed.Any(i => i.Rai > 50)
            || it.Harvests.Any(i => i.WaterFillingCount > 20 || i.WaterHeightCm > 20));
        }

        private bool checkFields(List<GrowingFieldWithNames> fields)
        {
            return fields != null && fields.Any(it => it.Area?.Rai > 50);
        }

        private bool checkFields(List<GrowingField> fields)
        {
            return fields != null && fields.Any(it => it.Area?.Rai > 50);
        }

        private bool checkFields(List<MixablePlantingField> fields)
        {
            return fields != null && fields.Any(it => it.Area?.Rai > 50 || it.PrimaryPlant?.PlantingCount > 20);
        }

        private bool checkAnimal(Farming animal)
        {
            return animal != null && (
                animal.Cow?.ItemCount > 200
                || animal.Buffalo?.ItemCount > 200
                || animal.Pig?.ItemCount > 200
                || animal.Goat?.ItemCount > 200
                || animal.Sheep?.ItemCount > 200
                || animal.Chicken?.ItemCount > 200
                || animal.Duck?.ItemCount > 200
                || animal.Goose?.ItemCount > 200
                || animal.SilkWool?.ItemCount > 200
                || animal.Other?.ItemCount > 200
            );
        }

        private bool checkAquaticAnimal(AquaticAnimals animal)
        {
            return animal != null && (
                checkFishFarming(animal.Fish, 9999)
                || checkFishFarming(animal.Shrimp, 100)
                || animal.Frog?.AnimalsCount > 1000
                || animal.Frog?.AnimalsCount < 20
                || checkFishFarming(animal.Crocodile)
                || checkFishFarming(animal.SnappingTurtle)
                || checkFishFarming(animal.Crab, 100)
                || checkFishFarming(animal.Turtle)
                || checkFishFarming(animal.Reddish, 100)
            );
        }

        private bool checkFishFarming(FishFarming fish, int count)
        {
            return fish != null && (
                fish.FieldCount > 20
                || fish.Fields.Any(it => it.Area?.Rai > 5 || it.Depth > 4 || it.Depth < 0.5 || it.Diameter > 100 || it.Diameter < 0.5)
                || fish.AnimalsCount > count
            );
        }

        private bool checkFishFarming(CrocodileFarming fish)
        {
            return fish != null && (
                fish.FieldCount > 20
                || fish.Fields.Any(it => it.Area?.Rai > 5 || it.Depth > 4 || it.Depth < 0.5 || it.Diameter > 100 || it.Diameter < 0.5)
                || fish.AnimalsCount > 100
                || fish.AnimalsCount < 10
            );
        }

        private bool checkCommerce(Commercial com)
        {
            return com != null && (
                com.QuestionForAcademy?.PreSchool?.ItemCount > 200
                || com.QuestionForAcademy?.Kindergarten?.ItemCount > 200
                || com.QuestionForAcademy?.PrimarySchool?.ItemCount > 200
                || com.QuestionForAcademy?.HighSchool?.ItemCount > 200
                || com.QuestionForAcademy?.Vocational?.ItemCount > 200
                || com.QuestionForAcademy?.HigherEducation?.ItemCount > 200
                || com.QuestionForAcademy?.PersonnelCount > 100
                || com.HotelsAndResorts?.RoomCount > 100
                || com.HotelsAndResorts?.PersonnelCount > 100
                || com.Hospital?.BedCount > 300
                || com.Hospital?.PersonnelCount > 500
                || com.Building?.RoomCount > 500
                || com.Building?.PersonnelCount > 100
                || com.Religious?.PeopleCount > 100
                || com.OtherBuilding?.PersonnelCount > 50
            );
        }

        private bool checkWaterUsage(WaterUsage water)
        {
            return water != null && (
                checkPlumbing(water.Plumbing)
                || checkGroundWater(water.GroundWater)
                || checkRiver(water.River)
                || checkPool(water.Pool)
                || checkIrrigation(water.Irrigation)
                || checkRain(water.Rain?.RainContainers)
                || checkBuying(water.Buying)
            );
        }

        private bool checkPlumbing(Plumbing plumbing)
        {
            return plumbing != null && (
                checkPlumbingInfo(plumbing.MWA)
                || checkPlumbingInfo(plumbing.PWA)
                || checkPlumbingInfo(plumbing.Other)
                || plumbing.WaterNotRunningCount > 12
            );
        }

        private bool checkPlumbingInfo(PlumbingInfo info)
        {
            return info.PlumbingUsage?.CubicMeterPerMonth > 1000 || info.PlumbingUsage?.WaterBill > 50000;
        }

        private bool checkGroundWater(GroundWater ground)
        {
            return ground != null && (
                checkPrivate(ground.PrivateGroundWater)
                || checkPublic(ground.PublicGroundWater)
            );
        }

        private bool checkPrivate(PrivateGroundWater ground)
        {
            return ground != null && (
                ground.AllCount > 10
                || ground.WaterResources.Any(it =>
                    it.UsageType?.UsageCubicMeters > 1000
                    || it.UsageType?.WaterBill > 100000
                    || checkPumps(it.Pumps))
            );
        }

        private bool checkPublic(PublicGroundWater ground)
        {
            return ground != null && (
                ground.WaterResources.Any(it =>
                    it.CubicMeterPerMonth > 1000
                    || checkPumps(it.Pumps))
            );
        }

        private bool checkRiver(River river)
        {
            return river != null && checkPumps(river.Pumps);
        }

        private bool checkPumps(List<Pump> pumps)
        {
            return pumps != null && pumps.Any(i =>
                i.HoursPerPump > 24
                || i.HoursPerPump < 0.1
                || i.NumberOfPumpsPerYear > 365
                || i.PumpRate > 50
            );
        }

        private bool checkPool(Pool pool)
        {
            return pool != null && (
                pool.PoolCount > 10
                || pool.PoolSizes.Any(it =>
                    it.Area?.Rai > 50
                    || it.Depth > 4
                    || it.Depth < 0.5
                    || it.Diameter > 100
                    || it.Diameter < 0.5)
                || pool.WaterResources.Any(it => checkPumps(it.Pumps))
            );
        }

        private bool checkIrrigation(Irrigation irrigate)
        {
            return irrigate != null && checkPumps(irrigate.Pumps);
        }

        private bool checkRain(List<RainContainer> container)
        {
            return container != null && container.Any(it => it.Count > 100);
        }

        private bool checkBuying(Buying buy)
        {
            return buy != null && buy.Package.Any(it =>
                it.Drink > 500
                || it.Agriculture > 500
                || it.Factory > 500
                || it.Service > 500
            );
        }

        private bool checkDisaster(Disasterous disaster)
        {
            return disaster?.YearsDisasterous != null && disaster.YearsDisasterous.Any(it => it.Count > 180 || it.AvgDay > 180 || it.WaterHeightCm > 500);
        }
    }
}
