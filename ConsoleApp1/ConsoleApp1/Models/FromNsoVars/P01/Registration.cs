using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ความเกี่ยวพันกับหัวหน้าครอบครัว
    /// </summary>
    public enum Registration
    {
        /// <summary>
        /// มีในบ้านนี้
        /// </summary>
        InThisHouse = 1,

        /// <summary>
        /// ไม่มีในบ้านนี้แต่มีในบ้านอื่นในจังหวัดนี้
        /// </summary>
        NoThisHouseInThisProvince = 2,

        /// <summary>
        /// ไม่มีในบ้านนี้แต่มีในจังหวัดอื่น
        /// </summary>
        NoThisHouseOtherProvince = 3,

        /// <summary>
        /// ไมมีในประเทศไทย แต่มีในประเทศอื่น
        /// </summary>
        NotInThailand = 4,

        /// <summary>
        /// ไม่มีที่ใดเลย
        /// </summary>
        NoWhere = 5,

        /// <summary>
        /// ไม่ทราบ
        /// </summary>
        Unknow = 9
    }
}