using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class WaterConsumptionUsingPumpBase
    {
        /// <summary>
        /// ใช้เครื่องสูบน้้าเพื่อสูบน้้าหรือไม่ (ถ้าไม่ใช้ ข้ามไปถามสระถัดไป)
        /// </summary>
        public bool? HasPump { get; set; }

        /// <summary>
        /// บ่อนี้ใช้เครื่องสูบน้้ากี่เครื่อง
        /// </summary>
        public int? PumpCount { get; set; }

        /// <summary>
        /// เครื่องสูบน้้าที่ใช้
        /// </summary>
        public List<Pump> Pumps { get; set; }

        /// <summary>
        /// ใช้น้้าจาก บ่อ / สระ นี้เพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร
        /// </summary>
        public WaterActivity WaterActivities { get; set; }

        /// <summary>
        /// ปัญหาคุณภาพน้้า
        /// </summary>
        public WaterProblem QualityProblem { get; set; }
         /// <summary>
        /// ตั้งอยู่ที่ใด
        /// </summary>
        public Location Location { get; set; }
    }
}
