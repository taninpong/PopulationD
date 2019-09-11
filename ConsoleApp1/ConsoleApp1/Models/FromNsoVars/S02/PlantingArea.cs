using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ลักษณะการใช้พื้นที่ในการเพาะปลูก
    /// </summary>
    public enum PlantingArea
    {
        /// <summary>
        /// 1. ทำทั้งแปลงทุกครั้ง
        /// </summary>
        AllArea         = 1,
        /// <summary>
        /// 2. ไม่ได้ทำทั้งแปลง แต่ทำเท่ากันทุกครั้ง
        /// </summary>
        EqualSize       = 2,
        /// <summary>
        /// 3. ไม่ได้ทำทั้งแปลง และทำไม่เท่ากันทุกครั้ง
        /// </summary>
        DifferentSize   = 3,
    }
}
