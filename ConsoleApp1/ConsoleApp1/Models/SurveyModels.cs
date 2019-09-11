using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSOWater.HotMigration.HotModels
{
    public class Building
    {
        public string _id { get; set; }
        [JsonProperty("ea")]
        public string EA { get; set; }
        public string Status { get; set; }
        public string HouseNo { get; set; }
        public string Name { get; set; }
        public string Road { get; set; }
        public int? BuildingType { get; set; }
        public RecCtrl RecCtrl { get; set; }
        public string unitCount { get; set; }
        public int? unitAccess { get; set; }
        public int?[] Accesses { get; set; }
        public Comment[] Comments { get; set; }
    }

    public class Unit
    {
        public string _id { get; set; }
        [JsonProperty("ea")]
        public string EA { get; set; }
        public string Status { get; set; }
        public string BuildingId { get; set; }
        public SubUnit SubUnit { get; set; }

        public SurveyCompleted[] SurveyCompleted { get; set; }
        public RecCtrl RecCtrl { get; set; }

        public Comment[] Comments { get; set; }
    }

    public class BuildingInList
    {
        public string BuildingId { get; set; }
    }

    public class UnitInList
    {
        public string HouseHoldId { get; set; }
    }

    public class CommunityInList
    {
        public string CommunityId { get; set; }
    }

    public class SurveyCompleted
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public bool HasCompleted { get; set; }
        public bool IsNeed { get; set; }
    }

    public class RecCtrl
    {
        //public DateTime CreatedDateTime { get; set; }
        public DateTime? LastModified { get; set; }
    }

    public class Comment
    {
        public long At { get; set; }
        public string Text { get; set; }
    }

    public class SubUnit
    {
        public string RoomNumber { get; set; }
        public int?[] Accesses { get; set; }
    }
}
