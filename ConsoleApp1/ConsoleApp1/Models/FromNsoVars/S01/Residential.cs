using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ครัวเรือนอยู่อาศัย
    /// </summary>
    public class Residential
    {
        /// <summary>
        /// จำนวนสมาชิกในครัวเรือนที่อยู่ประจำติดต่อกันตั้งแต่ 3 เดือนขึ้นไป
        /// </summary>
        public int? MemberCount { get; set; }
        /// <summary>
        /// คนที่อายุ 15-59 ปี
        /// </summary>
        public int? WorkingAge { get; set; }
        /// <summary>
        /// ใช้น้ำเพื่อการอุปโภคบริโภคจากแหล่งใดบ้าง
        /// </summary>
        public WaterSources WaterSources { get; set; }
        /// <summary>
        /// ใช้น้ำเพื่อรดน้ำต้นไม้ / สวนหย่อม / สวนครัว ในบริเวณที่อยู่อาศัยหรือไม่
        /// </summary>
        public bool? GardeningUse { get; set; }

    }
}
