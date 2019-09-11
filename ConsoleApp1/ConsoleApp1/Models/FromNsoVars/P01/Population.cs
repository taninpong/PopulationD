using System.Collections.Generic;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// สำมะโนประชากร
    /// </summary>
    public class Population
    {
        /// <summary>
        /// ครัวเรือนนี้เป็นครัวเรือนสถาบันหรือไม่
        /// </summary>
        public string Skip { get; set; }

        /// <summary>
        /// จำนวนคน
        /// </summary>
        public int? PersonCount { get; set; }
        public string AllPersonCount { get; set; }
        public string MalePerson { get; set; }
        public string FemalePerson { get; set; }
        /// <summary>
        /// ข้อมูลบุคคล
        /// </summary>
        public List<Person> Persons { get; set; }

    }
}