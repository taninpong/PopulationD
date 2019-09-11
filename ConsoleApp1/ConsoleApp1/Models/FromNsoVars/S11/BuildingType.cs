using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public enum BuildingType
    {
        /// <summary>
        /// 1 บ้านเดี่ยว 
        /// </summary>
        SingleHouse = 1,
        /// <summary>
        /// 2 บ้านแฝด/ทาวน์เฮ้าส์/ทาวน์โฮม 
        /// </summary>
        TownHouse = 2,
        /// <summary>
        /// 3 ห้องแถว/เรือนแถว/ตึกแถว  
        /// </summary>
        ShopHouse = 3,
        /// <summary>
        /// 4 อาคารสูง(คอนโดฯ/แมนชั่น/แฟลต/อพาร์ทเมนท์) 
        /// </summary>
        Apartment = 4,
        /// <summary>
        /// 5 อาคารสำนักงานเอกชน
        /// </summary>
        Office = 5,
        /// <summary>
        /// 6 โรงแรม/รีสอร์ท/เกสเฮาส์  
        /// </summary>
        Hotel = 6,
        /// <summary>
        /// 7 สถานพยาบาล : ภาครัฐ
        /// </summary>
        PublicHospital = 7,
        /// <summary>
        /// 8 สถานพยาบาล : ภาคเอกชน 
        /// </summary>
        PrivateHospital = 8,
        /// <summary>
        /// 9 สถานที่ราชการ/รัฐวิสาหกิจ 
        /// </summary>
        GovernmentOffice = 9,
        /// <summary>
        /// 10 ศาสนสถาน
        /// </summary>
        Religious = 10,
        /// <summary>
        /// 11 สถานศึกษา : ภาครัฐ   
        /// </summary>
        PublicSchool = 11,
        /// <summary>
        /// 12 สถานศึกษา : ภาคเอกชน  
        /// </summary>
        PrivateSchool = 12,
        /// <summary>
        /// 13 โกดัง / โรงงาน   
        /// </summary>
        Factory = 13,
        /// <summary>
        /// 14 โรงเรือนเพาะปลูก/เลี้ยงสัตว์   
        /// </summary>
        GreenHouse = 14,
        /// <summary>
        /// 15 อาคารกำลังก่อสร้าง   
        /// </summary>
        UnderConstruction = 15,
        /// <summary>
        /// 16 อื่นๆ  
        /// </summary>
        Other = 16     
    }
}