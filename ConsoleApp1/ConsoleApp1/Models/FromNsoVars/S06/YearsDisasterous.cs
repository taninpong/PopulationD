namespace NSOWater.HotMigration.Models
{
    public class YearsDisasterous
    {
        
        /// <summary>
        /// ปีที่เกิดอุทกภัย 2556-2560
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// FloodAmount - จำนวนครั้งที่เกิดอุทกภัย
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// ระยะเวลาที่เกิดน้ำท่วม  (โดยเฉลี่ย : จำนวนวัน)
        /// </summary>
        public int? AvgDay { get; set; }

        /// <summary>
        /// ระยะเวลาที่เกิดน้ำท่วม  (โดยเฉลี่ย : จำนวนชั่วโมง)
        /// ม่ีค่า 1-23
        /// </summary>
        public int? AvgHour { get; set; }

        /// <summary>
        /// ระดับความสูงของน้ำท่วม (ซม.)
        /// </summary>
        public double? WaterHeightCm { get; set; }
    }
}