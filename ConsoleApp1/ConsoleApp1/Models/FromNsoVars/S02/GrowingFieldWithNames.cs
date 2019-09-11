using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ข้อมูลแปลงเพาะปลูกพืช ที่ระบุชนิดพืชที่ปลูกด้วย
    /// </summary>
    public class GrowingFieldWithNames : GrowingField
    {
       
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาที่แปลงนี้ปลูกพืช ชนิดใด (ระบุได้ไม่เกิน 5 ชนิด) - รวมอื่นๆ
        /// </summary>
        public PlantItem Plantings { get; set; }
        
        /// <summary>
        /// อื่น ๆ รวมกับข้อข้างบนแล้วไม่เกิน 5 ชนิด
        /// </summary>
        /// <remarks>
        /// พืชอื่นๆ ให้ใส่กำหนดชื่อเอง ส่วนรหัส โปรแกรมจะกำหนดให้โดยแยกตามประเภทพืช
        /// เช่น พืชไร่ 3xxx, ไม้ดอก ไม้ประดับ 4xxx เป็นต้น
        /// </remarks>
        public PlantItem OtherPlantings { get; set; }
    }
}
