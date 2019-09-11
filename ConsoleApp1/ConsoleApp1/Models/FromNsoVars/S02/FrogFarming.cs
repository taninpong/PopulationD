namespace NSOWater.HotMigration.Models
{
    public class FrogFarming
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ท้าการเพาะเลี้ยง เพาะฟัก อนุบาลสัตว์น้้าในพื้นที่น้้าจืดหรือไม่
        /// (เฉพาะชนิดนี้)
        /// </summary>
        public bool? Doing { get; set; }
        /// <summary>
        ///  ลักษณะการเลี้ยงเป็นบ่อ
        /// </summary>
        public bool? Depression { get; set; }
        /// <summary>
        ///  ลักษณะการเลี้ยงเป็นกระชัง
        /// </summary>
        public bool? Stew { get; set; }
         /// <summary>
        ///  ลักษณะการเลี้ยงในที่อื่นๆ
        /// </summary>
        public bool? HasOther { get; set; }
        public string Other { get; set; }
        /// <summary>
        /// จ้านวนกบที่เลี้ยงเฉลี่ยต่อเดือน เดือนละกี่ตัว
        /// </summary>
        public int? AnimalsCount { get; set; }
        /// <summary>
        /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSources WaterSources { get; set; }
    }
}