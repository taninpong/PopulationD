using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    ///  ในรอบ 1 ปีที่ผ่านมา ใช้น้้าปริมาณเท่าไร ต่อเดือนโดยเฉลี่ย
    /// </summary>
    public enum GroundWaterQuantity
    {
        /// <summary>
        /// ทราบปริมาณน้้า 
        /// </summary>
        CubicMeterPerMonth            = 1,
        /// <summary>
        /// ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า 
        /// </summary>
        WaterBill       = 2,
        /// <summary>
        ///  ไม่ทราบ
        /// </summary>
        Unknown      = 3       
    }
}