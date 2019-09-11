using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// คำนำหน้าชื่อ
    /// </summary>
    public enum NameTitle
    {
        /// <summary>
        /// นาย 
        /// </summary>
        Mister = 1,

        /// <summary>
        /// นาง
        /// </summary>
        Mistress = 2,

        /// <summary>
        /// นางสาว
        /// </summary>
        Miss = 3,

        /// <summary>
        /// เด็กชาย
        /// </summary>
        Master = 4,

        /// <summary>
        /// เด็กหญิง
        /// </summary>
        Lessie = 5,

        /// <summary>
        /// อื่นๆ
        /// </summary>
        Other = 6
    }
}