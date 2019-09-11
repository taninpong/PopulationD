using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ข้อมูลการเพาะปลูกพืช
    /// </summary>
    /// <typeparam name="T">ข้อมูลการเพาะปลูกเฉพาะสำหรับพืชแต่ละแบบ</typeparam>
    public class PlantingInfo<T>
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้ปลูกพืช xxx หรือไม่
        /// </summary>
        public bool? Doing { get; set; }

        /// <summary>
        ///  มีพื้นที่ปลูก “xxx” จำนวนกี่แปลง
        /// </summary>
        public int? FieldCount { get; set; }

        /// <summary>
        /// แปลงที่ (แปลงที่ n) -- สอบถามทีละแปลง
        /// </summary>
        public List<T> Fields { get; set; }
    }
}
