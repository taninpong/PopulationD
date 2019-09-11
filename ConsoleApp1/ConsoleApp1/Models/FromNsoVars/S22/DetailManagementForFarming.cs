using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class DetailManagementForFarming
    {
        
        /// <summary>
        /// ชื่อโครงการ
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// พื้นที่ของโครงการมีกี่ไร่ ใช้ ไร่(Area->Rai) ตารางวา(Area-> SqWa)
        /// </summary>
        // TODO:
        public Area Area { get; set; }

        /// <summary>
        ///  จำนวนครัวเรือนที่เป็นสมาชิกโครงการมีจำนวนเท่าไร 
        /// </summary>
        public int? MemberCount { get; set; }

        /// <summary>
        ///  โครงการใช้น้้าผิวดินปริมาณโดยเฉลี่ยเดือนละเท่าไร (ให้รวมทุกพื้นที่ของโครงการ) 
        /// </summary>
        public int? AvgSurfaceWaterUse { get; set; }

        /// <summary>
        ///   โครงการมีบ่อน้้าบาดาลจำนวนกี่บ่อ  
        /// </summary>
        public int? GroundWaterCount { get; set; }

        /// <summary>
        ///   โครงการใช้น้้าบาดาลปริมาณโดยเฉลี่ยเดือนละเท่าไร (ให้รวมทุกพื้นที่ของโครงการ)  
        /// </summary>
        public int? AvgGroundWaterUse { get; set; }
    }
}
