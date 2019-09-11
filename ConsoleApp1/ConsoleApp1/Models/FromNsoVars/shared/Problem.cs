using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ปัญหาคุณภาพน้ำ
    /// </summary>
    public class Problem
    {
        /// <summary>
        /// ขุ่น/ตะกอน  
        /// </summary>
        public bool? TurbidWater { get; set; }
        /// <summary>
        /// เค็ม/กร่อย  
        /// </summary>
        public bool? SaltWater { get; set; }
        /// <summary>
        ///  มีกลิ่น
        /// </summary>
        public bool? Smell { get; set; }

        /// <summary>
        ///  คราบมัน
        /// </summary>
        public bool? FilmOfOil { get; set; }

        /// <summary>
        /// ฝ้าขาว
        /// </summary>
        public bool? FogWater { get; set; }
        /// <summary>
        ///  น้ำกระด้าง
        /// </summary>
        public bool? HardWater { get; set; }

    }
}