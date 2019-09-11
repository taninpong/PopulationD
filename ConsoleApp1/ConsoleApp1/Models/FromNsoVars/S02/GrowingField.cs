using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ข้อมูลแปลงเพาะปลูกพืช
    /// </summary>
    public class GrowingField
    {
        /// <summary>
        /// ตั้งอยู่ที่ใด
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// ขนาดพื้นที่เท่าไร กี่ไร่ กี่งาน กี่ตางรางวา
        /// </summary>
        public Area Area { get; set; }

        /// <summary>
        /// ที่แปลงนี้ตั้งอยู่ในเขตชลประทานหรือไม่
        /// </summary>
        public bool? IrrigationField { get; set; }

        /// <summary>
        /// ที่แปลงนี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSources WaterSources { get; set; }
    }
}
