using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// น้ำประปา 
    /// </summary>
    public class Plumbing
    {
        /// <summary>
        ///  น้้าประปานครหลวง
        /// </summary>DoingMWA
        public PlumbingInfo MWA { get; set; }
        /// <summary>
        ///  น้้าประปาส่วนภูมิภาค 
        /// </summary>
        public PlumbingInfo PWA { get; set; }
        /// <summary>
        ///  น้้าประปาอื่น ๆ (หมู่บ้าน,อบต.,เทศบาล,ชุมชน, นิคม, ภูเขา, ฯลฯ)  
        /// </summary>
        // TODO:Name
        public PlumbingInfo Other { get; set; }
        

        /// <summary>
        ///   ใช้น้้าเพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร(นครหลวง)   
        /// </summary>
        public WaterActivity WaterActivityMWA { get; set; }

        /// <summary>
        ///   ใช้น้้าเพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร(น้้ำประปาส่วนภมูิภาค)   
        /// </summary>
        public WaterActivity WaterActivityPWA { get; set; }

        /// <summary>
        ///   ใช้น้้าเพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร(น้ำประปาอื่น ๆ)   
        /// </summary>
        public WaterActivity WaterActivityOther { get; set; }
       
        
    
        /// <summary>
        ///   ในรอบ 12 เดือนที่ผ่านมา มีเหตุการณ์ที่น้ำประปาไม่ไหล ติดต่อกันเกิน 3 วันหรือไม่   
        /// </summary>
        public bool? HasWaterNotRunning { get; set; }
         /// <summary>
        ///   ถ้ามีเกิดเหตุการณ์ลักษณะนี้เป็นเวลากี่เดือน 
        /// </summary>
        public int? WaterNotRunningCount { get; set; }
    }
}