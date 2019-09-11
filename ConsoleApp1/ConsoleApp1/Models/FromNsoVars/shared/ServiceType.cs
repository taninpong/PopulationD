using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{

    public enum ServiceType
    {
        /// <summary>
        /// การก่อสร้างอาคาร
        /// </summary>
        Building = 1,
        /// <summary>
        /// งานวิศวกรรมโยธา 
        /// </summary>
        CivilEngineering = 2,
        /// <summary>
        /// งานก่อนสร้างเฉพาะงาน
        /// </summary>
        Construction = 3,
        /// <summary>
        /// การขายส่งและการขายปลีก การซ่อมยานยนต์และจักรยานยนต์
        /// </summary>
        WholesaleRetail = 4,
        /// <summary>
        /// การขายส่ง (ยกเว้นยานยนต์และจักรยานยนต์) 
        /// </summary>
        Wholesale = 5,
        /// <summary>
        /// การขายปลีก (ยกเว้นยานยนต์และจักรยานยนต์) 
        /// </summary>
        Retail = 6,
        /// <summary>
        /// การขนส่งทางบกและการขนส่งทางท่อลำเลียง 
        /// </summary>
        Transport = 7,
        /// <summary>
        /// การขนส่งทางน้ำ 
        /// </summary>
        WaterTransport = 8,
        /// <summary>
        /// การขนส่งทางอากาศ 
        /// </summary>
        AirFreight = 9,
        /// <summary>
        /// กิจกรรมคลังสินค้าและกิจกรรมที่สนับสนุนการขนส่ง
        /// </summary>
        Warehouse = 10,
        /// <summary>
        /// กิจกรรมไปรษณีย์และการรับส่งพัสดุภัณฑ์ 
        /// </summary>
        Post = 11,
        /// <summary>
        /// ที่พักแรม (ระยะสั้น) 
        /// </summary>
        Accommodation = 12,
        /// <summary>
        /// การบริการอาหารและเครื่องดื่ม 
        /// </summary>
        FoodAndBeverageService = 13,
        /// <summary>
        /// การผลิตภาพยนตร์ วีดีทัศน์ และรายการโทรทัศน์ การบันทึกเสียงลงบนสื่อ และการจัดพิมพ์จำหน่ายหรือเผยแพร่ดนตรี 
        /// </summary>
        FilmProduction = 14,
        /// <summary>
        /// การจัดผังรายการและการแพร่ภาพกระจายเสียง 
        /// </summary>
        Broadcasting = 15,
        /// <summary>
        /// การโทรคมนาคม 
        /// </summary>
        Telecommunication = 16,
        /// <summary>
        /// การจัดทำโปรแกรมคอมพิวเตอร์ การให้คำปรึกษาเกี่ยวกับคอมพิวเตอร์ และกิจกรรมที่เกี่ยวข้อง 
        /// </summary>
        Programming = 17,
        /// <summary>
        /// การบริการสารสนเทศ 
        /// </summary>
        InformationServices = 18,
        /// <summary>
        /// กิจกรรมบริการทางการเงิน (ยกเว้นการประกันภัยและกองทุนบำเหน็จบำนาญ) 
        /// </summary>
        Money = 19,
        /// <summary>
        /// การประกันภัย การประกันภัยต่อ และกองทุนบำเหน็จบำนาญ (ยกเว้นการประกันสังคมภาคบังคับ) 
        /// </summary>
        Insurance = 20,
        /// <summary>
        /// กิจกรรมสนับสนุนการบริการทางการเงินและประกันภัย 
        /// </summary>
        Financial = 21,
        /// <summary>
        /// กิจกรรมอสังหาริมทรัพย์ 
        /// </summary>
        RealEstate = 22,
        /// <summary>
        /// กิจกรรมทางกฏหมายและการบัญชี 
        /// </summary>
        Legal = 23,
        /// <summary>
        /// กิจกรรมของสำนักงานใหญ่และการบริการให้คำปรึกษาด้านการบริหารจัดการ 
        /// </summary>
        HeadOffice = 24,
        /// <summary>
        /// กิจกรรมด้านสถาปัตยกรรมและวิศวกรรม รวมถึงการทดสอบและการวิเคราะห์ทางเทคนิค 
        /// </summary>
        Architectural = 25,
        /// <summary>
        /// การวิจัยและพัฒนาเชิงวิทยาศาสตร์ 
        /// </summary>
        ScientificResearch = 26,
        /// <summary>
        /// การโฆษณาและการวิจัยตลาด 
        /// </summary>
        Advertising = 27,
        /// <summary>
        /// กิจกรรมทางวิชาชีพ วิทยาศาสตร์ และเทคนิคอื่นๆ 
        /// </summary>
        ProfessionalActivity = 28,
        /// <summary>
        /// การบริการรักษาสัตว์ 
        /// </summary>
        AnimalTreatment = 29,
        /// <summary>
        /// กิจกรรมการให้เช่า 
        /// </summary>
        Rental = 30,
        /// <summary>
        /// กิจกรรมการจ้างงาน 
        /// </summary>
        Employment = 31,
        /// <summary>
        /// กิจกรรมของตัวแทนธุรกิจท่องเที่ยว การจัดนำเที่ยว การบริการสำรอง และกิจกรรมที่เกี่ยวข้อง 
        /// </summary>
        Travel = 32,
        /// <summary>
        /// การบริการรักษาความปลอดภัยและการสืบสวน 
        /// </summary>
        Security = 33,
        /// <summary>
        /// กิจกรรมการบริการสำหรับอาคารและภูมิทัศน์ 
        /// </summary>
        ServicesForBuilding = 34,
        /// <summary>
        /// การบริการด้านบริหารและสนับสนุนการดำเนินงานของสำนักงานและกิจกรรมอื่นๆที่สนับสนุนทางธุรกิจ 
        /// </summary>
        Support = 35,
        /// <summary>
        /// การศึกษา 
        /// </summary>
        Education = 36,
        /// <summary>
        /// กิจกรรมด้านสุขภาพของมนุษย์ 
        /// </summary>
        Health = 37,
        /// <summary>
        /// กิจกรรมการให้การดูแลที่ให้ที่พัก 
        /// </summary>
        ProvideCare = 38,
        /// <summary>
        /// กิจกรรมสังคมสงเคราะห์ที่ไม่ให้ที่พัก 
        /// </summary>
        SocialHousing = 39,
        /// <summary>
        /// กิจกรรมการสร้างสรรค์ศิลปะและความบันเทิง 
        /// </summary>
        Creative = 40,
        /// <summary>
        /// กิจกรรมห้องสมุด หอจดหมายเหตุ พิพิธภัณฑสถาน และกิจกรรมทางวัฒนธรรมอื่นๆ
        /// </summary>
        Library = 41,
        /// <summary>
        /// กิจกรรมการพนันและการเสี่ยงโชค 
        /// </summary>
        Gambling = 42,
        /// <summary>
        /// กิจกรรมด้านการกีฬา ความบันเทิงและนันทนาการ 
        /// </summary>
        Sport = 43,
        /// <summary>
        /// กิจกรรมองค์การสมาชิก
        /// </summary>
        Membership = 44,
        /// <summary>
        /// การซ่อมคอมพิวเตอร์และของใช้ส่วนบุคคลและของใช้ในครัวเรือน 
        /// </summary>
        Repairing = 45,
        /// <summary>
        /// กิจกรรมบริการส่วนบุคคลอืนๆ 
        /// </summary>
        OtherPersonal = 46,
        /// <summary>
        /// ศาสนสถาน 
        /// </summary>
        Religious = 47,
        /// <summary>
        /// การราชการ การป้องกันประเทศ และการประกันสังคมภาคบังคับ 
        /// </summary>
        Government = 48,
    }
}