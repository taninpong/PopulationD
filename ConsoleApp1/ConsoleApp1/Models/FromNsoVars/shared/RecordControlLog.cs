using System;

namespace NSOWater.HotMigration.Models
{
    public class RecordControlLog
    {
        public DateTime? At { get; set; }
        /// <summary>
        /// เดี๋ยวกำหนดอีกที เช่น เริ่มสำรวจ, หยุดชั่วคราว, ไปต่อ ไรงี้
        /// </summary>
        public string OperationCode { get; set; }
    }
}
