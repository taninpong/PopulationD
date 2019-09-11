using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ปริมาณน้้าประปาที่ใช้เฉลี่ยเดือนละเท่าไร 
    /// </summary>
    public class PlumbingUsage
    {

        /// <summary>
        /// ปริมาณน้้าประปาที่ใช้เฉลี่ยเดือนละเท่าไร 
        /// </summary>
        /// <remarks>
        /// 1.ทราบปริมาณน้้า
        /// 2.ไม่ทราบปริมาณน้้า แต่ทราบค่าน้้า
        /// 3.ไม่ทราบปริมาณน้้าและค่าน้้าเนื่องจากไม่มีมิเตอร์แยกจากส่วนกลาง
        /// 4.ไม่ทราบปริมาณน้้าและค่าน้้าเนื่องจากได้รับการยกเว้น   
        /// </remarks>
        public WaterQuantity? WaterQuantity { get; set; }
        /// <summary>
        /// ปริมาณน้ำ ลบ.ม./เดือน  
        /// </summary>
        public int? CubicMeterPerMonth { get; set; }

        /// <summary>
        /// ทราบค่าน้้า
        /// </summary>
        public double? WaterBill { get; set; }

    }
}