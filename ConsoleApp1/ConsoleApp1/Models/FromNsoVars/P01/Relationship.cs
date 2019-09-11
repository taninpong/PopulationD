using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public enum Relationship
    {
        /// <summary>
        /// หัวหน้าครอบครัว
        /// </summary>
        HeadFamily = 1,

        /// <summary>
        /// ภรรยาหรือสามี
        /// </summary>
        HusbandOrWife = 2,

        /// <summary>
        /// บุตร ยังไม่สมรส
        /// </summary>
        ChildUnmarried = 3,

        /// <summary>
        /// บุตรสมรสแล้ว
        /// </summary>
        ChildMarried = 4,

        /// <summary>
        /// บุตรเขย บุตรสะใภ้
        /// </summary>
        ChildInLaw = 5,

        /// <summary>
        /// บุตรของบุตร
        /// </summary>
        Grandchild = 6,

        /// <summary>
        /// พ่อ, แม่, พ่อแม่ของคู่สมรส
        /// </summary>
        Parents = 7,

        /// <summary>
        /// ญาติอื่นๆ
        /// </summary>
        Relative = 8,

        /// <summary>
        /// ผู้อาศัย/คนรับใช้/คนงาน
        /// </summary>
        Tenant = 9,

        /// <summary>
        /// คนงาน/พระสงฆ์/เณร/อื่นๆ
        /// </summary>
        Other = 10,
    }
}