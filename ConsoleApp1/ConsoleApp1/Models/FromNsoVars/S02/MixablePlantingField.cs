using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ข้อมูลแปลงเพาะปลูก พืชสมุนไพร ที่ปลูกผสมกับพืชหลักอื่นได้
    /// </summary>
    public class MixablePlantingField : GrowingFieldWithNames
    {
        /// <summary>
        /// ลักษณะการปลูกเป็นแบบใด
        /// </summary>
        /// <remarks>
        ///     True - 1. ปลูกเฉพาะ พืชผัก สมุนไพร
        ///     False - 2. ปลูกแบบปะปนกัน กับพืชชนิดอื่น
        /// </remarks>
        public bool? ThisPlantOnly { get; set; }

        /// <summary>
        /// รายชื่อพืชที่ปลูกหลัก
        /// </summary>
        public PlantItem PrimaryPlant { get; set; }

    }
}
