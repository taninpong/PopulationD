using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// แหล่งน้ำที่นำมาใช้ 8 ตัว ไม่มีน้ำฝนธรรมชาติ
    /// </summary>
    public class WaterSources
    {
        /// <summary>
        /// 1. น้ำประปา
        /// </summary>
        public bool? Plumbing { get; set; }
        /// <summary>
        /// 2. น้ำบาดาล
        /// </summary>
        public bool? UnderGround { get; set; }
        /// <summary>
        /// 3. น้ำจากสระน้ำ
        /// </summary>
        public bool? Pool { get; set; }
        /// <summary>
        /// 4. น้ำจากแม่น้ำ / ลำคลอง / แหล่งน้ำสาธารณะ
        /// </summary>
        public bool? River { get; set; }
        /// <summary>
        /// 5. น้ำจากชลประทาน
        /// </summary>
        public bool? Irrigation { get; set; }
        /// <summary>
        /// 6. น้ำฝนที่กักเก็บไว้
        /// </summary>
        public bool? Rain { get; set; }
        /// <summary>
        /// 7. น้ำที่ซื้อมาใช้
        /// </summary>
        public bool? Buying { get; set; }
        /// <summary>
        /// 8. น้ำฝนตามธรรมชาติ
        /// </summary>
        public bool? RainingAsIs { get; set; }
        /// <summary>
        /// 9. อื่น ๆ (ระบุ)
        /// </summary>
        public bool? HasOther { get; set; }
        public string Other { get; set; }
    }
}
