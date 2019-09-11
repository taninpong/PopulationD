using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// การนำน้ำออกมาใช้โดยใช้ปั๊มน้ำ แบบที่ถามปริมาณน้ำก่อน ถ้าไม่ทราบค่อยถามหาปั๊ม
    /// </summary>
    public class WaterConsumptionUsingPump : WaterConsumptionUsingPumpBase
    {
        /// <summary>
        /// ทราบปริมาณน้ำที่นำมาใช้โดยเฉลี่ยต่อเดือนหรือไม่
        /// </summary>
        public bool? HasCubicMeterPerMonth { get; set; }

        /// <summary>
        /// ปริมาณน้ำ ลบ.ม./เดือน  
        /// </summary>
        public int? CubicMeterPerMonth { get; set; }
    }
}
