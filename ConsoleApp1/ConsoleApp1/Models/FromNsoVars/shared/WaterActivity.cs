using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ***ปรากฏกิจกรรมเฉพาะที่ระบุไว้ก่อนหน้าว่าใช้น้้า
    /// </summary>
    public class WaterActivity
    {
        /// <summary>
        /// 1.ใช้เพื่ออุปโภคบริโภค
        /// </summary>
        public int? Drink { get; set; }

        /// <summary>
        /// 2.เพื่อรดน้้าพืชในบริเวณที่อยู่อาศัย
        /// </summary>
        public int? Plant { get; set; }
        /// <summary>
        /// 3..เพื่อทำนา
        /// </summary>
        public int? Farm { get; set; }

        /// <summary>
        /// 4.ใช้เพื่อท้าเกษตร
        /// </summary>
        public int? Agriculture { get; set; }

        /// <summary>
        /// 45.เพื่อผลิตสินค้า
        /// </summary>
        public int? Product { get; set; }

        /// <summary>
        /// 6.เพื่อการบริการ
        /// </summary>
        public int? Service { get; set; }
       
        
    }
}