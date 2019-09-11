using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// ข้อมูลการทำนาแต่ละครั้ง
    /// </summary>
    public class RicePlantingHarvest
    {
        /// <summary>
        ///   การทำนา เริ่มทำเดือนใด   
        /// </summary>
        public int? PlantingFromMonth { get; set; }
        /// <summary>
        ///   การทำนา ทำถึงเดือนใด   
        /// </summary>
        public int? PlantingThruMonth { get; set; }
        /// <summary>
        /// การทำนา ปล่อยน้้าเข้านากี่ครั้ง (ถ้าไม่ได้ปล่อยน้ำให้กรอก 0)
        /// </summary>
        public int? WaterFillingCount { get; set; }
        /// <summary>
        /// การทำนา โดยเฉลี่ยแต่ละครั้งปล่อยน้้าสูง กี่ เซนติเมตร
        /// </summary>
        public double? WaterHeightCm { get; set; }
    }
}
