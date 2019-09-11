using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;

namespace NSOWater.HotMigration.HotModels
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
        [JsonProperty("MUN_NAME")]
        public string MUN_NAME { get; set; }
        [JsonProperty("TAO_NAME")]
        public string TAO_NAME { get; set; }
        [JsonProperty("EA")]
        public string EA { get; set; }
        [JsonProperty("VIL")]
        public string VIL { get; set; }
        [JsonProperty("VIL_NAME")]
        public string VIL_NAME { get; set; }
        [Obsolete]
        public DateTime? FsConfirm { get; set; } //remove
        [Obsolete]
        public DateTime? PsConfirm { get; set; } //remove
        public DateTime? PsCofirmFs { get; set; }
        public DateTime? PsConfirmFi { get; set; }
        public int ProgressBuilding { get; set; }
        public int? TargettBuilding { get; set; }
        public int ProgressUnit { get; set; }
        public int? TargetUnit { get; set; }
        public DateTime? StatusAssignWorkFs { get; set; }
        public DateTime? StatusAssignWorkFi { get; set; }
        public DateTime? DateApproveFs { get; set; }
        public DateTime? DateApprovePs { get; set; }
        [Obsolete]
        public DateTime? DateApproveFi { get; set; } // remove change name to DataApprovePs
        public DateTime? StatusPayFs { get; set; }
        public DateTime? StatusPayFi { get; set; }
        public double CostFs { get; set; }
        public double CostFi { get; set; }
        public double PaidFs { get; set; }
        public double PaidFi { get; set; }
        public int CountFs { get; set; }
        public int CountFi { get; set; }
        public string ApproveByPs { get; set; }
        public string ApproveByFs { get; set; }
        public string FsConfirmByPs { get; set; }
        public string FiConfirmByPs { get; set; }
    }
}
