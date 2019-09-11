namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// การเลี้ยงสัตว์น้ำ
    /// </summary>
    public class AquaticAnimals
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ท้าการเพาะเลี้ยง เพาะฟัก อนุบาลสัตว์น้้าในพื้นที่น้้าจืดหรือไม่ 
        /// </summary>
        public bool? Doing { get; set; }
        /// <summary>
        /// Check ปลา
        /// </summary>
        public bool? IsFish { get; set; }
        /// <summary>
        /// ปลา
        /// </summary>
        public FishFarming Fish { get; set; }    
        /// <summary>
        /// Check กุ้ง
        /// </summary>
        public bool? IsShrimp { get; set; }    
        /// <summary>
        /// กุ้ง
        /// </summary>
        public FishFarming Shrimp { get; set; }
        /// <summary>
        /// Check กบ
        /// </summary>
        public bool? IsFrog { get; set; }
        /// <summary>
        /// กบ
        /// </summary>
        public FrogFarming Frog { get; set; }
        /// <summary>
        /// Check จระเช้
        /// </summary>
        public bool? IsCrocodile { get; set; }
        /// <summary>
        /// จระเข้
        /// </summary>
        public CrocodileFarming Crocodile { get; set; }
        /// <summary>
        /// Check ตะพาบน้ำ
        /// </summary>
        public bool? IsSnappingTurtle { get; set; }
        /// <summary>
        /// ตะพาบน้ำ
        /// </summary>
        public CrocodileFarming SnappingTurtle { get; set; }
        /// <summary>
        /// Check ปู
        /// </summary>
        public bool? IsCrab { get; set; }
        /// <summary>
        /// ปู
        /// </summary>
        public FishFarming Crab { get; set; }
        /// <summary>
        /// Check หอย
        /// </summary>
        public bool? IsShellFish { get; set; }
        /// <summary>
        /// หอย
        /// </summary>
        public FishFarming ShellFish { get; set; }
        /// <summary>
        /// Check เต่า
        /// </summary>
        public bool? IsTurtle { get; set; }
        /// <summary>
        /// เต่า
        /// </summary>
        public CrocodileFarming Turtle { get; set; }
        /// <summary>
        /// Check ไรแดง
        /// </summary>
        public bool? IsReddish { get; set; }
        /// <summary>
        /// ไรแดง
        /// </summary>
        public FishFarming Reddish { get; set; }
        // TODO:ใส่ฟอร์มเพิ่มให้ครบ - (เสร็จแล้ว)
    }
}