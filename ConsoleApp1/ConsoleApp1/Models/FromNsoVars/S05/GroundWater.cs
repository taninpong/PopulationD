using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// น้ำบาดาล
    /// </summary>
    public class GroundWater
    {
        /// <summary>
        /// 5.2.1 บ่อน้้าบาดาลส่วนตัวหรือไม่
        /// </summary>
        public PrivateGroundWater PrivateGroundWater { get; set; }

        /// <summary>
        /// 5.2.4 บ่อน้ำสาธารณะ
        /// </summary>
        public PublicGroundWater PublicGroundWater { get; set; }
    }
}