using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// บรรจุภัณ
    /// </summary>
    // TODO: More Info
    public class RainContainer
    {
        /// <summary>
        /// ประเภทของบรรจุภัณ
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// ขนาดของบรรจุภัณ
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// จำนวน
        /// </summary>
        public int? Count { get; set; }
    }
}