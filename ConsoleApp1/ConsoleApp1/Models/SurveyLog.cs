using Newtonsoft.Json;
using System;

namespace NSOWater.HotMigration.HotModels
{
    public class SurveyLog
    {
        public string SessionId { get; set; }
        public DateTime CreationDateTime { get; set; }

        public string _id { get; set; }
        public string SampleId { get; set; }
        public string SampleType { get; set; }
        public string Name { get; set; }
        public string BuildingId { get; set; }
        public string Province { get; set; }
        public string UserId { get; set; }
        [JsonProperty("ea")]
        public string EA { get; set; }
        public string ContainerName { get; set; }
        public string BlobName { get; set; }
        public int? BuildingType { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Status { get; set; }
        public int?[] Accesses { get; set; }
        public bool Enlisted { get; set; }
    }
}
