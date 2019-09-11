using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ครัวเรือน - หน่วยตัวอย่าง
    /// </summary>
    public class HouseHoldSample : ModelBase
    {
        public string EA { get; set; }
        public string BuildingId { get; set; }

        /// <summary>
        /// ข้อมูลหน่วยย่อย บันทึกเมื่อ N > 1
        /// </summary>
        public SubUnit SubUnit { get; set; }

        /// <summary>
        /// G1 - สถานที่นี้มีผู้อยู่อาศัยติดต่อกันนานเกิน 3 เดือนใช่หรือไม่ 
        /// </summary>
        public bool? IsHouseHold { get; set; }
        /// <summary>
        /// G2 - ผู้ที่อาศัยอยู่ในสถานที่นี้มีพื้นที่ปลกูพืชเลี้ยงสัตว์หรือท้าการเกษตรเองใช่หรือไม่ 
        /// </summary>
        public bool? IsAgriculture { get; set; }
        /// <summary>
        /// G3 - สถานที่นี้ใช้เพื่อทำการผลิตใช่หรือไม่ 
        /// </summary>
        public bool? IsFactorial { get; set; }
        /// <summary>
        /// G4 - สถานที่นี้ใช้เพื่อทำการบริการใช่หรือไม่ 
        /// </summary>
        public bool? IsCommercial { get; set; }

        /// <summary>
        /// บันทึกปัญหา/อุปสรรค หรือข้อความทั่วไปเพื่อเตือนความจำ
        /// </summary>
        public List<Comment> Comments { get; set; }

        public string Status { get; set; }

        /// <summary>
        /// ครัวเรือนที่อยู่อาศัย
        /// </summary>
        public Residential Residence { get; set; }
        /// <summary>
        /// การทำการเกษตร
        /// </summary>
        public Agriculture Agriculture { get; set; }
        /// <summary>
        /// การผลิตสินค้า
        /// </summary>
        public Factorial Factory { get; set; }
        /// <summary>
        /// การค้าและการบริการ
        /// </summary>
        public Commercial Commerce { get; set; }
        /// <summary>
        /// การใช้น้ำ
        /// </summary>
        public WaterUsage WaterUsage { get; set; }
        /// <summary>
        /// ปัญหาอุทกภัย
        /// </summary>
        public Disasterous Disaster { get; set; }

        /// <summary>
        /// ข้อมูลพื้นฐานส่วนบุคคล
        /// </summary>
        public ClosingInfo Closing { get; set; }

        /// <summary>
        /// สำมะโนประชากร
        /// </summary>
        public Population Population { get; set; }

        /// <summary>
        /// Record Control Compartment
        /// </summary>
        public RecordControl RecCtrl { get; set; }
    }
}