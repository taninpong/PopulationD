using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    // TODO: Mushroom Copy from GrowingField
    /// <summary>
    ///  เพาะเชื้อและปลูกเห็ด 
    /// </summary>
    public class MushroomField
    {
        /// <summary>
        /// ตั้งอยู่ที่ใด
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// ขนาดพื้นที่เท่าไร กี่ตางรางวา
        /// </summary>
        public string AreaSqM { get; set; }
        /// <summary>
        /// ตั้งอยู่ในเขตชลประทานหรือไม่
        /// </summary>
        public bool? IrrigationField { get; set; }
        /// <summary>
        /// ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSources WaterSources { get; set; }
    }
}
