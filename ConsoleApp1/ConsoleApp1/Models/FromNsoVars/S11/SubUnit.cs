using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class SubUnit
    {
        /// <summary>
        /// หมายเลขห้อง, ใช้ '-' แทนส่วนกลาง
        /// </summary>
        public string RoomNumber { get; set; }
        public int? AccessCount { get; set; }
        public int?[] Accesses { get; set; }

        /// <summary>
        /// P1 - ใช้น้ำประปาหรือไม่
        /// </summary>
        public bool? HasPlumbing { get; set; }
        /// <summary>
        /// P2.1 - มีมิเตอรน้ำประปาแยกจากส่วนกลางหรือไม่ 
        /// </summary>
        public bool? HasPlumbingMeter { get; set; }
        /// <summary>
        /// P2.2 - ถ้ามเป็นมิเตอร์ของการประปาส่วนภูมิภาค/นครหลวงใช่หรือไม่
        /// </summary>
        public bool? IsPlumbingMeterXWA { get; set; }
        /// <summary>
        /// P3 - ใช้น้ำบาดาลหรือไม่
        /// </summary>
        public bool? HasGroundWater { get; set; }
        /// <summary>
        /// P4 - มีมิเตอร์น้ำบาดาลแยกจากส่วนกลางหรือไม่
        /// </summary>
        public bool? HasGroundWaterMeter { get; set; }
    }
}
