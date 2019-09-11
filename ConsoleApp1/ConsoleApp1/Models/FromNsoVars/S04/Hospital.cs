using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// คำถามสำหรับสถานพยาบาล
    /// </summary>
    public class Hospital
    {
        /// <summary>
        /// จำนวนเตียง
        /// </summary>
        public int? BedCount { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int? PersonnelCount { get; set; }
    }
}