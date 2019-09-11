using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// การใช้น้ำ
    /// </summary>
    public class WaterUsage 
    {
        /// <summary>
        /// น้ำประปา
        /// </summary>
        public Plumbing Plumbing { get; set; }
        /// <summary>
        /// น้ำบาดาล
        /// </summary>
        /// // TODO:5.3, 5.4, 5.5 ทำใหม่
        public GroundWater GroundWater { get; set; }
        /// <summary>
        /// น้ำจากแม่น้ำ / ลำคลอง / แหล่งน้ำสาธารณะ
        /// </summary>
        public River River { get; set; }
        /// <summary>
        /// น้ำจากสระน้ำ/หนองน้ำ/บึง
        /// </summary>
        public Pool Pool { get; set; }
        /// <summary>
        /// น้ำจากชลประทาน
        /// </summary>
        public Irrigation Irrigation { get; set; }
        /// <summary>
        /// น้ำฝนที่กักเก็บไว้
        /// </summary>
        public Rain Rain { get; set; }

        /// <summary>
        /// น้ำที่ซื้อมาใช้
        /// </summary>
        public Buying Buying { get; set; }


    }
}
