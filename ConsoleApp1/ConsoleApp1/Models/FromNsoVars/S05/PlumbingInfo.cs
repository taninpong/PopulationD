using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    public class PlumbingInfo
    {
        /// <summary>
        ///  ใช้หรือไม่
        /// </summary>
        public bool? Doing { get; set; }

        /// <summary>
        /// ปัญหาคุณภาพน้ำ
        /// </summary>
        public WaterProblem QualityProblem { get; set; }

        /// <summary>
        ///  ปริมาณน้้าประปาที่ใช้เฉลี่ยเดือนละเท่าไร 
        /// </summary>
        public PlumbingUsage PlumbingUsage { get; set; }        
    }
}