using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class FieldSize
    {
        /// <summary>
        /// ลักษณะพื้นที่เลี้ยงสัตว์น้ำ
        /// </summary>
        public FieldShape? Shape { get; set; }
        /// <summary>
        ///  บ่อหรือร่องสวน  พื้นที่ กี่ไร่ กี่งาน  กี่ตารางวา
        /// </summary>
        public Area Area { get; set; }
        /// <summary>
        /// ความลึกของบ่อกี่เมตร 
        /// </summary>
        public double? Depth { get; set; }
        /// <summary>
        ///  ถ้าบ่อเป็นสี่เหลี่ยม กว้าง ยาว ลึกเท่าไร 
        /// </summary>
        public RectanglePool Rectangle { get; set; }
        /// <summary>
        ///  ถ้าบ่อเป็นวงกลม เส้นผ่านศูนย์กลางกี่เมตร ลึก เท่าไร 
        /// </summary>
        public double? Diameter { get; set; }
         /// <summary>
        /// ตั้งอยู่ที่ใด
        /// </summary>
        public Location Location { get; set; }
    }
}
