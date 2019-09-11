using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// บ้าน / อาคาร / สิ่งปลูกสร้้าง
    /// </summary>
    public class BuildingSample : ModelBase
    {
        /// <summary>
        /// รหัสเขตแจงนับ
        /// </summary>
        public string EA { get; set; }
        // TODO: เอามั้ย?
        /// <summary>
        /// ลำดับที่บ้าน/อาคาร/สิ่งปลูกสร้าง
        /// </summary>
        public int? Ordering { get; set; }
        /// <summary>
        /// ชื่อถนนลำน้ำหรือละแวกบ้าน
        /// </summary>
        public string Road { get; set; }
        /// <summary>
        /// ชื่อตรอก/ซอย
        /// </summary>
        public string Alley { get; set; }
        /// <summary>
        /// ชื่อหมู่บ้าน/คอนโด/อาคาร/สำนักงาน/สถานประกอบการ/สถาบัน ฯลฯ 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// เลขที่บ้าน/อาคาร
        /// </summary>
        public string HouseNo { get; set; }
        /// <summary>
        /// ละติจูด 
        /// </summary>
        public double? Latitude { get; set; }
        /// <summary>
        /// ลองจิจูด
        /// </summary>
        public double? Longitude { get; set; }
        /// <summary>
        /// ประเภทบ้าน/อาคาร/สิ่งปลูกสร้าง 
        /// </summary>
        public BuildingType? BuildingType { get; set; }
        /// <summary>
        /// อื่นๆ (ระบุประเภทอาคาร)
        /// </summary>
        public string Other { get; set; }

        public int? AccessCount { get; set; }
        /// <summary>
        /// รหัสการเข้าพบ บ้าน/อาคาร/สิ่งปลูกสร้าง
        /// </summary>
        public int?[] Accesses { get; set; }

        /// <summary>
        /// จำนวนบ้านว่าง 
        /// </summary>
        public int? VacancyCount { get; set; }
        /// <summary>
        /// จำนวนบ้านร้าง
        /// </summary>
        public int? AbandonedCount { get; set; }

        public int? UnitCountComplete { get; set; }

        /// <summary>
        /// N - จำนวนครัวเรือน/สถานประกอบการรวมทั้งหมดในบ้าน/อาคาร/สิ่งปลูกสร้าง 
        /// </summary>
        public int? UnitCount { get; set; }

        /// <summary>
        /// ได้รับอนุญาตให้เก็บข้อมูลผู้พักอาศัยในอาคารหรือไม่
        /// 1 อนุญาต      
        /// 2 ไม่อนุญาตแต่ให้ข้อมูล 
        /// 3 ไม่อนุญาตและไม่ให้ข้อมลู
        /// </summary>
        public UnitAccess? UnitAccess { get; set; }

        /// <summary>
        /// จ้านวนห้องว่าง
        /// </summary>
        public int? VacantRoomCount { get; set; }
        /// <summary>
        /// จำนวนห้องที่มีผู้อาศัย/จำนวนสถานประกอบการ
        /// </summary>
        public int? OccupiedRoomCount { get; set; }
        /// <summary>
        /// ปริมาณน้ำ
        /// </summary>
        public PlumbingUsage WaterQuantity { get; set; }
        /// <summary>
        ///  จำนวนชั้น (สำหรับอาคารสูง 4 หรือ 5)
        /// </summary>
        public double? FloorCount { get; set; }

        /// <summary>
        /// บันทึกปัญหา/อุปสรรค หรือข้อความทั่วไปเพื่อเตือนความจำ
        /// </summary>
        public List<Comment> Comments { get; set; }


        /// <summary>
        /// Record Control Compartment
        /// </summary>
        public RecordControl RecCtrl { get; set; }

        public string Status { get; set; }
    }
}
