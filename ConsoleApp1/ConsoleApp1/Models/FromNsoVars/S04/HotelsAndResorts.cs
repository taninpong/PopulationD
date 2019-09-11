using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// คำถามสำหรับสถานบริการห้องพัก
    /// </summary>
    public class HotelsAndResorts
    {
        /// <summary>
        /// จำนวนห้องพัก
        /// </summary>
        public int? RoomCount { get; set; }

         /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int? PersonnelCount { get; set; }
    }
}