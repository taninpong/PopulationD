using System;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// บ่อน้ำส่วนตัว
    /// </summary>
    public class PrivateGroundWater : WaterResourceBase<GroundWaterWell>
    {
        /// <summary>
        /// ถ้ามีบ่อน้้าบาดาลส่วนตัว มีจ้านวนกี่บ่อ 
        /// </summary>
        public int? AllCount { get; set; }
    }
}
