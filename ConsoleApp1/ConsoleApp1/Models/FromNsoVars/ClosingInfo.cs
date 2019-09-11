using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class ClosingInfo
    {
        /// <summary>
        /// ชื่อผู้ให้ข้อมูล 
        /// </summary>
        public string Informer { get; set; }
        /// <summary>
        /// ประเภทสถานประกอบการผลิต 
        /// </summary>
        public FactorialCategory? FactorialCategoryCode { get; set; }
        /// <summary>
        /// ประเภทสถานประกอบการบริการ 
        /// </summary>
        public ServiceType? ServiceTypeCode { get; set; }
    }
}