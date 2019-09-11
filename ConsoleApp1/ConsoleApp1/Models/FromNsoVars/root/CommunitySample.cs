using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// พื้นที่ย่อย
    /// </summary>
    public class CommunitySample : ModelBase
    {
        public string EA { get; set; }
        /// <summary>
        /// การจัดการน้ำในหมู่บ้าน / ชุมชน
        /// </summary>
        public CommunityWaterManagement Management { get; set; }

        /// <summary>
        /// โครงการจัดการน้้าเพื่อการเกษตรชุมชน  โดยใช้พื้นที่สาธารณะ
        /// </summary>
        public ManagementForFarming CommunityProject { get; set; }

        public string Status { get; set; }

    }
}
