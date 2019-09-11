using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ปัญหาอุทกภัย
    /// </summary>
    // TODO: go
    public class Disasterous:ModelBase
    {
        /// <summary>
        /// ในรอบ 5 ปีที่ผ่านมา (2556-2560) ที่อยู่อาศัยนี้ประสบปัญหาอุทกภัย (น้ำท่วมขัง น้ำรอการระบาย) หรือไม่
        /// </summary>
        public bool? Flooded { get; set; }

        /// <summary>
        /// มีปัญหาอุทกภัยรอบ 5 ปีที่ผ่านมา (2556-2560)
        /// </summary>
        public List<YearsDisasterous> YearsDisasterous { get; set; }
    }
}
