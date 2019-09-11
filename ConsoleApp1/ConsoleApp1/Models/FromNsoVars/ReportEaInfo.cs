using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebManageAPI.Models
{
    public class ReportEaInfo
    {
        [BsonId]
        [JsonProperty("EaCode")]
        public string _id { get; set; }
        [JsonProperty("Area_Code")]
        public string Area_Code { get; set; }
        [JsonProperty("REG")]
        public string REG { get; set; }
        [JsonProperty("REG_NAME")]
        public string REG_NAME { get; set; }
        [JsonProperty("CWT")]
        public string CWT { get; set; }
        [JsonProperty("CWT_NAME")]
        public string CWT_NAME { get; set; }
        [JsonProperty("AMP")]
        public string AMP { get; set; }
        [JsonProperty("AMP_NAME")]
        public string AMP_NAME { get; set; }
        [JsonProperty("TAM")]
        public string TAM { get; set; }
        [JsonProperty("TAM_NAME")]
        public string TAM_NAME { get; set; }
        [JsonProperty("DISTRICT")]
        public int DISTRICT { get; set; }
        [JsonProperty("EA")]
        public string EA { get; set; }
        public DateTime? FsConfirm { get; set; }
        public DateTime? PsConfirm { get; set; }
        public int ProgressBuilding { get; set; }
        public int? TargettBuilding { get; set; }
        public int ProgressUnit { get; set; }
        public int? TargetUnit { get; set; }
        public DateTime? StatusAssignWorkFs { get; set; }
        public DateTime? StatusAssignWorkFi { get; set; }
        public DateTime? DateApproveFs { get; set; }
        public DateTime? DateApproveFi { get; set; }
        public DateTime? StatusPayFs { get; set; }
        public DateTime? StatusPayFi { get; set; }
        public double CostFs { get; set; }
        public double CostFi { get; set; }
        public double PaidFs { get; set; }
        public double PaidFi { get; set; }
    }
}
