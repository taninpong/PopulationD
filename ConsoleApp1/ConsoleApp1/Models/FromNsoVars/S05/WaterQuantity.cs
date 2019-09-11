using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ทราบปริมาณน้้า
    /// </summary>
    public enum WaterQuantity
    {
        /// <summary>
        /// ทราบปริมาณน้้า 
        /// </summary>
        CubicMeterPerMonth = 1,
        /// <summary>
        /// ไม่ทราบปริมาณน้้า แต่ทราบค่าน้้า 
        /// </summary>
        WaterBill = 2,
        /// <summary>
        ///  ไม่ทราบปริมาณน้้าและค่าน้้าเนื่องจากไม่มีมิเตอร์แยกจากส่วนกลาง 
        /// </summary>
        UnknowNoMeter = 3,
        /// <summary>
        ///   ไม่ทราบปริมาณน้้าและค่าน้้าเนื่องจากได้รับการยกเว้น   
        /// </summary>
        UnknowExcepted = 4
    }

}

