using NSOWater.HotMigration.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NsoGetData.Models
{
    class BldData
    {
        public string  _id { get; set; }
        public string EA { get; set; }
        public int? Ordering { get; set; }
        public string Road { get; set; }
        public string Alley { get; set; }
        public string Name { get; set; }
        public string HouseNo { get; set; }
        public BuildingType? BuildingType { get; set; }
    }
    class BldData2
    {
        public string _id { get; set; }
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
    }
}
