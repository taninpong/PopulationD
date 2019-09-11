using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class DisasterWarningMethod
    {
        /// <summary>
        /// 2.1 ระบบเป็นไปตามระบบของทางราชการ 
        /// </summary>
        public bool? GovernmentProcess { get; set; }
        /// <summary>
        /// 2.2 มี โดยหมู่บ้าน/ชุมชนร่วมกันวางแผนจัดการเอง
        /// </summary>
        public bool? CommunityPlan { get; set; }
        /// <summary>
        /// 2.3 มี โดยมีหน่วยงานอื่นให้ค้าแนะน้าและบริหารจัดการ
        /// </summary>
        public bool? ConsultingService { get; set; }
        /// <summary>
        /// 2.4 มี ลักษณะการด้าเนินงานอื่น
        /// </summary>
        public bool? HasOther { get; set; }

        /// <summary>
        /// ระบุลักษณะการดำเนินการมาตรการเตือนภัย
        /// </summary>
        public string Other { get; set; }
    }
}
