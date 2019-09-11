using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class NaturalDisaster
    {
        /// <summary>
        /// สึนามิ
        /// </summary>
        public bool? Tsunami { get; set; }
        /// <summary>
        /// ดินโคลนถล่ม
        /// </summary>
        public bool? LandSlide { get; set; }
        /// <summary>
        /// แผ่นดินไหว
        /// </summary>
        public bool? Earthquake { get; set; }
        /// <summary>
        /// พายุ
        /// </summary>
        public bool? Cyclone { get; set; }
        /// <summary>
        /// ไฟป่า
        /// </summary>
        public bool? ForestFire { get; set; }
        /// <summary>
        /// ภัยแล้ง
        /// </summary>
        public bool? Drought { get; set; }
        /// <summary>
        /// ภัยหนาว
        /// </summary>
        public bool? Cold { get; set; }
        /// <summary>
        /// โรคระบาดในมนุษย์
        /// </summary>
        public bool? Epidemic { get; set; }
        /// <summary>
        /// แมลง ศัตรูพืช
        /// </summary>
        public bool? Pest { get; set; }
        /// <summary>
        /// โรคระบาดสัตว์
        /// </summary>
        public bool? Epizootics { get; set; }
    }
}
