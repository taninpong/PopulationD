using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class PlantItem
    {
        /// <summary>
        /// จำนวนของชนิดพืชที่ปลูก
        /// </summary>
        /// <remarks>
        /// Max 5
        /// </remarks>
        public int? PlantingCount { get; set; }
        public List<Plant> Plants { get; set; }
    }

    
}
