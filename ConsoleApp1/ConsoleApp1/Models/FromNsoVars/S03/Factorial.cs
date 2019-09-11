using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// การผลิตสินค้า
    /// </summary>
    public class Factorial
    {
        /// <summary>
        /// ชื่อสถานประกอบการ / หน่วยงาน
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// สถานประกอบการแห่งนี้ผลิตสินค้าประเภทใด
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// สถานประกอบการแห่งนี้มีคนทำงานรวมทั้งหมดกี่คน
        /// </summary>
        public int? WorkersCount { get; set; }
        /// <summary>
        /// สถานประกอบการแห่งนี้ใช้เครื่องจักรที่มีขนาดแรงม้าตั้งแต่ 5 แรงม้าหรือ 3,725 วัตต์ขึ้นไป หรือไม่ boolean
        /// </summary>
        public bool? HeavyMachine { get; set; }
        /// <summary>
        /// แหล่งที่มาของน้ำ
        /// </summary>
        public WaterSources WaterSources { get; set; }
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาสถานประกอบการนี้มีน้ำเสียจากกระบวนการผลิตสินค้าหรือไม่
        /// </summary>
        // TODO:
        public bool? HasWasteWaterFromProduction { get; set; }
        /// <summary>
        /// ถ้า“มี”น้้าเสีย สถานประกอบการนี้มีการจัดการน้ำเสียที่เกิดจากกระบวนการผลิตสินค้าหรือไม่   (ให้กา  ใน  เพียงข้อเดียว) 
        /// </summary>
        public bool? HasWasteWaterTreatment { get; set; }

        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมา สถานประกอบการนี้มีการน้า น้ำที่ผ่านกระบวนการผลิตสินค้าแล้วกลับมาใช้ ใหม่หรือไม่  (ให้กา  ใน  เพียงข้อเดียว)
        /// </summary>
        public bool? WasteWaterReuse { get; set; }
        
        
    }
    
}
