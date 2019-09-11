using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class DetailWaterManagement
    {
        /// <summary>
        /// ชื่อของแหล่งน้ำ
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้ท้าน้้าประปา
        /// </summary>
        public bool? UseForPlumbing { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้ท้าการผลิต/อุตสาหกรรม 
        /// </summary>
        public bool? UseForFactory { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อการเกษตร 
        /// </summary>
        public bool? UseForFarming { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อการบริการ 
        /// </summary>
        public bool? UseForService { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อวัตถุประสงค์อื่นๆ
        /// </summary>
        public bool? UseForOther { get; set; }
        /// <summary>
        /// ระบุชื่อหากใช้แหล่งน้ำนี้เพื่อประโยชน์อื่นๆ
        /// </summary>
        public string Other { get; set; }

        /// <summary>
        /// พื้นที่ของแหล่งน้ำ
        /// </summary>
        public FieldSizeForCommu ProjectArea { get; set; }
    }
}
