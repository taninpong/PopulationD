using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ขาดพื้นที่เป็น ไร่ งาน และ ตารางวา
    /// </summary>
    public class Area
    {
        /// <summary>
        /// ไร่
        /// </summary>
        public double? Rai { get; set; }
        /// <summary>
        /// งาน
        /// </summary>
        public double? Ngan { get; set; }
        /// <summary>
        /// ตารางวา
        /// </summary>
        public double? SqWa { get; set; }
    }
}
