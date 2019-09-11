using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// สระน้้า หนองน้้า บึง 
    /// </summary>
    public class Pool : WaterResourceBase<WaterConsumptionUsingPump>
    {
        /// <summary>
        /// หาก “มี” มีจำนวนกี่สระ
        /// </summary>
        public int? PoolCount { get; set; }

        /// <summary>
        /// ขนาดสระน้้าทั้งหมดเท่ากันหรือไม่ (ให้ถามถ้าจ้านวนสระในข้อ 5.4.2 มากกว่า 1 สระ)
        /// </summary>
        public bool? HasSameSize { get; set; }

        /// <summary>
        /// ถามขนาดของสระ
        /// </summary>
        public List<FieldSize> PoolSizes { get; set; }
    }
}