using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models 
{
    /// <summary>
    /// ตำแหน่ง ที่ตั้ง
    /// </summary>
    public class Location {
        /// <summary>
        /// จังหวัด
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// อำเภอ
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// ตำบล
        /// </summary>
        public string SubDistrict { get; set; }
    }
}