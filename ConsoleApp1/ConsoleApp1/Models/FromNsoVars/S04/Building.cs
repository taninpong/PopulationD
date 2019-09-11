using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// คำถามสำหรับปลูกสร้าง
    /// </summary>
    public class Building
    {
        /// <summary>
        /// จำนวนห้อง
        /// </summary>
        public int? RoomCount { get; set; }

        /// <summary>
        /// จำนวนห้องที่มีคนอาศัย
        /// </summary>
        // TODO:
        public int? OccupiedRoomCount { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int? PersonnelCount { get; set; }
    }
}