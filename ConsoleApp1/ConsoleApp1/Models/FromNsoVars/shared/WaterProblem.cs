using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ปัญหาคุณภาพน้้า
    /// </summary>
    public class WaterProblem
    {
        /// <summary>
        /// มีปัญหาคุณภาพน้้า หรือไม่
        /// </summary>
        public bool? HasProblem { get; set; }

        /// <summary>
        /// ปัญหา
        /// </summary>
        public Problem Problem { get; set; }
    }
}