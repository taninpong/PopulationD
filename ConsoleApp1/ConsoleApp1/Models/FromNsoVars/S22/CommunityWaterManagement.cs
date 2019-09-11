using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class CommunityWaterManagement
    {
        public string Vil { get; set; }
        public string Vil_name { get; set; }
        /// <summary>
        /// ในหมู่บ้าน/ชุมชนแห่งนี้มี แหล่งน้้าสาธารณะ (สระน้้า/ หนอง/ บึง/ อ่างเก็บน้้า) หรือไม่ 
        /// </summary>
        public bool? HasPublicWater { get; set; }

        /// <summary>
        /// หาก “มี” มีจ้านวนกี่แหล่ง
        /// </summary>
        public int? PublicWaterCount { get; set; }

        /// <summary>
        /// รายละเอียดของแหล่งน้ำสาธารณะ 
        /// </summary>
        public List<DetailWaterManagement> Details { get; set; }


        /// <summary>
        ///  น้้าประปาส่วนภูมิภาค  
        /// </summary>
        public bool? PWA { get; set; }

        /// <summary>
        ///   น้้าประปานครหลวง 
        /// </summary>
        public bool? MWA { get; set; }

        /// <summary>
        ///   น้้าประปาอื่นๆ 
        /// </summary>
        public bool? OtherPlumbing { get; set; }

        /// <summary>
        /// ในหมู่บ้าน/ชุมชน เป็นที่ตั้งของแหล่งผลิตน้้าประปาอื่นๆ (หมู่บ้าน, อบต., เทศบาล, ชุมชน, นิคม, ภูเขา, ฯลฯ)  ใช่หรือไม่ 
        /// </summary>
        public bool? HasWaterService { get; set; }

        /// <summary>
        /// หาก “ใช่” ในหมู่บ้าน/ชุมชน มีแหล่งผลิตน้้าประปาอื่นๆ กี่หน่วยงาน 
        /// </summary>
        public int? WaterServiceCount { get; set; }

        /// <summary>
        /// รายละเอียดของหน่วยงานแหล่งผลิตน้ำประปา
        /// </summary>
        public List<DetailOrgWaterSupply> WaterServices { get; set; }

        /// <summary>
        /// ในหมู่บ้าน/ชุมชนมีระบบบ้าบัดน้้าเสียหรือไม่  (ให้กา  ใน  เพียงข้อเดียว) 
        /// </summary>
        public bool? HasWaterTreatment { get; set; }


        /// <summary>
        /// ในช่วงเวลา 5 ปีที่ผ่านมา หมู่บ้าน/ชุมชนแห่งนี้เคยเกิดภัยธรรมชาติหรือไม่  
        /// </summary>
        public bool? HasDisaster { get; set; }
        /// <summary>
        /// ถ้าเคย ภัยธรรมชาติที่เกิดมีอะไรบ้าง (ให้เลือกได้หลายข้อ) 
        /// </summary>
        public NaturalDisaster Disasters { get; set; }

        /// <summary>
        /// ในหมู่บ้าน/ชุมชนแห่งนี้มีการเตือนภัยและมาตรการช่วยเหลือน้้าท่วมหรือไม่  
        /// </summary>
        public bool? HasDisasterWarning { get; set; }
        /// <summary>
        ///  ถ้ามีลักษณะการดำเนินการเป็นอย่างไร (ให้เลือกได้หลายข้อ)   
        /// </summary>
        public DisasterWarningMethod DisasterWarningMethods { get; set; }
    }
}
