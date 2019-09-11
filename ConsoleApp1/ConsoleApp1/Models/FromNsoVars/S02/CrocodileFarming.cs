using System.Collections.Generic;

namespace NSOWater.HotMigration.Models
{
    public class CrocodileFarming
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ท้าการเพาะเลี้ยง เพาะฟัก อนุบาลสัตว์น้้าในพื้นที่น้้าจืดหรือไม่
        /// (เฉพาะชนิดนี้)
        /// </summary>
        public bool? Doing { get; set; }
         /// <summary>
        ///  ลักษณะการเลี้ยงเป็นบ่อ
        /// </summary>
        public  bool? Depression { get; set; }
         /// <summary>
        ///  ลักษณะการเลี้ยงในที่อื่นๆ
        /// </summary>
        public bool? HasOther { get; set; }
        public  string Other { get; set; }
         /// <summary>
        ///  ถ้าเลี้ยงในบ่อ หรือร่องสวน มีจ้านวนบ่อหรือ ร่องสวนรวมเท่าไร 
        /// </summary>
        public int? FieldCount { get; set; }
        /// <summary>
        /// ขนาดบ่อหรือร่องสวนทั้งหมดเท่ากันหรือไม่  
        /// </summary>
        /// <remarks>
        ///     True - 1. เท่ากัน (ให้ถามขนาดบ่อครั้งเดียว)
        ///     False - 2. ไม่เท่ากัน (ให้ถามทีละบ่อ)
        /// </remarks>
        public bool? FieldsAreSameSize { get; set; }

        /// <summary>
        /// บ่อหรือร่องสวน (ที่ n) -- สอบถามทีละบ่อ
        /// </summary>
        public List<FieldSize> Fields { get; set; }
        /// <summary>
        /// จ้านวนที่เลี้ยงในปัจจุบัน (รวมทุกบ่อ/ร่องสวน) 
        /// </summary>
        public int? AnimalsCount { get; set; }
        /// <summary>
        /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSources WaterSources { get; set; }
    }
}