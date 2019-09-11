using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class WaterUsageRate
    {
        public WaterUsage WaterUsage { get; set; }
        public Residential Residence { get; set; }
        public BuildingType? BuildingType { get; set; }
        public List<CommunitySample> Communities { get; set; }
    }
}