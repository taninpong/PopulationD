using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// การกักเก็บน้าฝน ***แสดงข้อมูล ชนิดพืช/การผลิต/การบริการ ที่เลือกใช้น้าฝนที่กักเก็บไว้ 
    /// </summary>
    public class Rain
    {
        /// <summary>
        /// - ภาชนะกักเก็บ
        /// </summary>
        public List<RainContainer> RainContainers { get; set; }
        
        /// <summary>
        /// - กิจกรรมการใช้น้า
        /// </summary>
        // TODO: Type
        public WaterActivity WaterActivities { get; set; }

    }
}