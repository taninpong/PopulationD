using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// บ่อบาดาล สำหรับข้อมูลบ่อบาดาลทั้งส่วนตัวและสาธารณะ
    /// </summary>
    public class GroundWaterWell : WaterConsumptionUsingPumpBase
    {
        /// <summary>
        ///  ใช้น้้าปริมาณเท่าไรต่อเดือนโดยเฉลี่ย   
        /// </summary>
        /// <remarks>
        /// 1.ทราบปริมาณน้้า
        /// 2.ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า
        /// 3.ไม่ทราบ
        /// </remarks>
        public GroundWaterUsage UsageType { get; set; }

        // /// <summary>
        // /// ปริมาณน้ำ ลบ.ม./เดือน  
        // /// </summary>
        // public int? CubicMeterPerMonth { get; set; }

        // /// <summary>
        // /// ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า 
        // /// </summary>
        // public int? WaterBill { get; set; }
    }
}
