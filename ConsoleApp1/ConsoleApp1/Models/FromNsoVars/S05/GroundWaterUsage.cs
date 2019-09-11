using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    // บ่อน้้าบาดาลส่วนตัว 
    /// <summary>
    ///  ในรอบ 1 ปีที่ผ่านมาใช้น้้าปริมาณเท่าไรต่อเดือนโดยเฉลี่ย 
    /// </summary>
    public class GroundWaterUsage
    {
        /// <summary>
        ///  ในรอบ 1 ปีที่ผ่านมา ใช้น้้าปริมาณเท่าไร ต่อเดือนโดยเฉลี่ย
        /// </summary>
        /// <remarks>
        /// 1.ทราบปริมาณน้้า
        /// 2.ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า
        /// 3.ไม่ทราบ
        /// </remarks>
        public GroundWaterQuantity? GroundWaterQuantity { get; set; }
        /// <summary>
        ///  ลบ.ม./เดือน  
        /// </summary>
        public int? UsageCubicMeters { get; set; }
        /// <summary>
        /// ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า 
        /// </summary>
        public int? WaterBill { get; set; }
              
    }
    
}
