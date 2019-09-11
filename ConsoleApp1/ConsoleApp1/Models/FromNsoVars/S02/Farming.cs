namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// 2.8 การเลี้ยงสัตว์เพื่อขายหรือใช้งานเกษตร 
    /// </summary>
    public class Farming
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้มีการเลี้ยงสัตว์ เพื่อขายหรือใช้งานเกษตรหรือไม่
        /// </summary>
        public bool? Doing { get; set; }
        // TODO: bool HasXXX, int XXXCount
        /// <summary>
        /// วัว
        /// </summary>
        public HasAndCount Cow { get; set; }

        /// <summary>
        /// ควาย
        /// </summary>
        public HasAndCount Buffalo { get; set; }

        /// <summary>
        /// หมู
        /// </summary>
        public HasAndCount Pig { get; set; }

        /// <summary>
        /// แพะ
        /// </summary>
        public HasAndCount Goat { get; set; }

        /// <summary>
        /// แกะ
        /// </summary>
        public HasAndCount Sheep { get; set; }

        /// <summary>
        /// ไก่
        /// </summary>
        public HasAndCount Chicken { get; set; }
        
        /// <summary>
        /// เป็ด
        /// </summary>
        public HasAndCount Duck { get; set; }
        /// <summary>
        /// ห่าน
        /// </summary>
        public HasAndCount Goose { get; set; }
        /// <summary>
        /// ไหม(น้้าหนักรังไหมเป็น กก.)
        /// </summary>
        public HasAndCount SilkWool { get; set; }
        /// <summary>
        /// อื่นๆ(เช่น ฟาร์มสุนัข แมว กระต่าย หนู นกกระจอกเทศ)
        /// </summary>
        public HasAndCount Other { get; set; }
        /// <summary>
        /// ชื่อสัตว์อื่นๆ
        /// </summary>
        public string OtherName { get; set; }
        /// หน่วยของสัตว์
        /// </summary>
        public string AnimalUnit { get; set; }
        /// <summary>
        // /// <summary>
        // /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        // /// </summary>
        public WaterSources WaterSources { get; set; }

    }
}