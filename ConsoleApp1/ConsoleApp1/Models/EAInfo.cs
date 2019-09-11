using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebManageApi.AnalyticFunction.Models
{
    public class EAInfo
    {
        //[BsonId]
        //public string Code { get; set; }
        //public string Area_Code { get; set; }
        //public string REG { get; set; }
        //public string REG_NAME { get; set; }
        //public string CWT { get; set; }
        //public string CWT_NAME { get; set; }
        //public string AMP { get; set; }
        //public string AMP_NAME { get; set; }
        //public string TAM { get; set; }
        //public string TAM_NAME { get; set; }
        //public int DISTRICT { get; set; }
        //public string MUN { get; set; }
        //public string MUN_NAME { get; set; }
        //public string TAO { get; set; }
        //public string TAO_NAME { get; set; }
        //public string EA { get; set; }
        //public string VIL { get; set; }
        //public string VIL_NAME { get; set; }
        //public int? MAP_STATUS { get; set; }
        //public int? Building { get; set; }
        //public int? Household { get; set; }
        //public int? population { get; set; }
        //public int? Agricultural_HH { get; set; }
        //public string ES_BUSI { get; set; }
        //public string ES_INDUS { get; set; }
        //public string ES_HOTEL { get; set; }
        //public string ES_PV_HOS { get; set; }
        //public string REMARK { get; set; }
        //public string linkcode { get; set; }
        //public IGeometry Center { get; set; }

        [BsonId]
        [JsonProperty("code")]
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
        [JsonProperty("MUN")]
        public string MUN { get; set; }
        [JsonProperty("MUN_NAME")]
        public string MUN_NAME { get; set; }
        [JsonProperty("TAO")]
        public string TAO { get; set; }
        [JsonProperty("TAO_NAME")]
        public string TAO_NAME { get; set; }
        [JsonProperty("EA")]
        public string EA { get; set; }
        [JsonProperty("VIL")]
        public string VIL { get; set; }
        [JsonProperty("VIL_NAME")]
        public string VIL_NAME { get; set; }
        [JsonProperty("MAP_STATUS")]
        public int? MAP_STATUS { get; set; }
        [JsonProperty("Building")]
        public int? Building { get; set; }
        [JsonProperty("Household")]
        public int? Household { get; set; }
        [JsonIgnore]
        public int? population { get; set; }
        [JsonIgnore]
        public int? Agricultural_HH { get; set; }
        [JsonIgnore]
        public string ES_BUSI { get; set; }
        [JsonIgnore]
        public string ES_INDUS { get; set; }
        [JsonIgnore]
        public string ES_HOTEL { get; set; }
        [JsonIgnore]
        public string ES_PV_HOS { get; set; }
        [JsonProperty("REMARK")]
        public string REMARK { get; set; }
        [JsonIgnore]
        public string linkcode { get; set; }

        [JsonProperty("Center")]
        public MongoDB.Bson.BsonDocument Center { get; set; }
    }
    public class IGeometry
    {
        public double[] coordinates { get; set; }
    }
}
