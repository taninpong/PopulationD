using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models 
{
    /// <summary>
    /// 2.1 ข้าว
    /// </summary>
    public class RicePlant {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้ปลูกข้าวเองหรือไม่
        /// </summary>
        public bool? Doing { get; set; }

        /// <summary>
        ///  “ปลูกข้าว” มีแปลงนาจ้านวนกี่แปลง
        /// </summary>
        public int? FieldCount { get; set; }

        /// <summary>
        /// แปลงนา (แปลงที่ n) -- สอบถามทีละแปลง
        /// </summary>
        public List<RicePlantingField> Fields { get; set; }
   }
}