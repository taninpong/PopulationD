using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models {
    
    /// <summary>
    /// 2. การทำการเกษตร
    /// </summary>
    public class Agriculture 
    {
        /// <summary>
        /// 2.1 ข้าว
        /// </summary>
        public PlantingInfo<RicePlantingField> RicePlant { get; set; }

        /// <summary>
        /// 2.2 พืชไร่
        /// </summary>
        public PlantingInfo<GrowingFieldWithNames> AgronomyPlant { get; set; }

        /// <summary>
        /// 2.3 ยางพารา 
        /// </summary>
        public PlantingInfo<GrowingField> RubberTree { get; set; }

        /// <summary>
        /// 2.4 พืชยืนต้น ไม้ผล สวนป่า 
        /// </summary>
        public PlantingInfo<GrowingFieldWithNames> PerennialPlant { get; set; }

        /// <summary>
        /// 2.5 พืชผัก สมุนไพร
        /// </summary>
        public PlantingInfo<MixablePlantingField> HerbsPlant { get; set; }

        /// <summary>
        /// 2.6 ไม้ดอกไม้ประดับ การเพาะพันธุ์ไม้ 
        /// </summary>
        public PlantingInfo<MixablePlantingField> FlowerCrop { get; set; }

        /// <summary>
        /// 2.7 เพาะเชื้อและปลูกเห็ด 
        /// </summary>
        public PlantingInfo<MushroomField> MushroomPlant { get; set; }

        /// <summary>
        /// 2.8 การเลี้ยงสัตว์เพื่อขายหรือใช้งานเกษตร 
        /// </summary>
        public Farming AnimalFarm { get; set; }

        /// <summary>
        /// 2.9 การเพาะเลี้ยงสัตว์น้ำในพื้นที่น้ำจืด 
        /// </summary>
        public AquaticAnimals AquaticAnimals { get; set; }

    }
}