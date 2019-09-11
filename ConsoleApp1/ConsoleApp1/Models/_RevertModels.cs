using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSOWater.HotMigration.HotModels
{
    public class FsMoney
    {
        [BsonId]
        public string _id { get; set; }
        public string FsId { get; set; }
        public string PsId { get; set; }
        public double? Amount { get; set; }
        public DateTime? FromDateTime { get; set; }
        public DateTime? ThruDateTime { get; set; }
    }
    public class FiMoney
    {
        public string _id { get; set; }//EA + FI ID
        public string FiId { get; set; }
        public string FiName { get; set; }
        public string FsId { get; set; }
        public string PsId { get; set; }
        public string EaCode { get; set; }
        public DateTime? PaidFs { get; set; }
        public string PaidFsRefId { get; set; }// _id ของ Reccord FsMoney
        public int BuildingDoneAll { get; set; }
        public int BuildingSad { get; set; }
        public int BuildingMicOff { get; set; }     //new
        public int BuildingEyeOff { get; set; }
        public int BuildingCheckMark { get; set; }
        public int BuildingInformation { get; set; }
        public int HouseholdComplete { get; set; }
        public int HouseholdMicOff { get; set; }
        public int HouseholdEyeOff { get; set; }
        public int HouseholdPause { get; set; }     //new
        public int HouseholdRefresh { get; set; }   //new
        public int HouseholdSad { get; set; }   //new
        public int ComunityComplete { get; set; }
        public double Amount { get; set; }
        public DateTime? CreationDateTime { get; set; }
    }
    public class RevertReportEaInfo
    {
        public RevertReportEaInfo(ReportEaInfo data, DateTime currentTime, string chainid)
        {
            _id = Guid.NewGuid().ToString();
            DataId = data._id;
            Data = data;
            CreationDate = currentTime;
            ChainId = chainid;
        }
        public string _id { get; set; }
        public string DataId { get; set; }
        public ReportEaInfo Data { get; set; }
        public DateTime CreationDate { get; set; }
        public string ChainId { get; set; }
    }
    public class RevertFiMoney
    {
        public RevertFiMoney(FiMoney data, DateTime currentTime, string chainid)
        {
            _id = Guid.NewGuid().ToString();
            DataId = data._id;
            Data = data;
            CreationDate = currentTime;
            ChainId = chainid;
            FiId = data.FiId;
        }
        public string _id { get; set; }
        public string DataId { get; set; }
        public string FiId { get; set; }
        public FiMoney Data { get; set; }
        public DateTime CreationDate { get; set; }
        public string ChainId { get; set; }
    }
    public class RevertFsMoney
    {
        public RevertFsMoney(FsMoney data, DateTime currentTime, string chainid)
        {
            _id = Guid.NewGuid().ToString();
            DataId = data._id;
            Data = data;
            CreationDate = currentTime;
            ChainId = chainid;
            FsId = data.FsId;
        }
        public string _id { get; set; }
        public string DataId { get; set; }
        public string FsId { get; set; }
        public FsMoney Data { get; set; }
        public DateTime CreationDate { get; set; }
        public string ChainId { get; set; }
    }
    public class RevertEaLog
    {
        public RevertEaLog(string eaCode, string message = "")
        {
            EaCode = eaCode;
            Message = message;
        }

        public string EaCode { get; }
        public string Message { get; }
        public string FiMoneyId { get; set; }
        public string FiId { get; set; }
        public string RelatedFsId { get; set; }
        public string FsMoneyId { get; set; }
        public string FsId { get; set; }
    }

    public class RevertSurveyLog
    {
        [BsonId]
        public string _id { get; set; }
        public string Ea { get; set; }
        public string UserId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
