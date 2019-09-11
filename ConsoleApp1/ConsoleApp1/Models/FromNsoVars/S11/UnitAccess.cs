using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ได้รับอนุญาตให้เก็บข้อมูลผู้พักอาศัยในอาคารหรือไม่
    /// </summary>
    public enum UnitAccess
    {
        /// <summary>
        /// อนุญาต 
        /// </summary>
        Allow = 1,
        /// <summary>
        ///  ไม่อนุญาตแต่ให้ข้อมูล 
        /// </summary>
        NotAllowGiveInfo = 2,
        /// <summary>
        ///  ไม่อนุญาตและไม่ให้ข้อมูล
        /// </summary>
        NotAllowNoInfo = 3,
    }
}