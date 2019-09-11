using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// คำถามสำหรับสถานศึกษา
    /// </summary>
    public class Academy 
    {
        // TODO:Count, int?
        /// <summary>
        /// ก่อนวัยเรียน 
        /// </summary>
        public HasAndCount PreSchool { get; set; }

        /// <summary>
        /// อนุบาล  
        /// </summary>
        public HasAndCount Kindergarten { get; set; }

        /// <summary>
        /// ประถมศึกษา  
        /// </summary>
        public HasAndCount PrimarySchool { get; set; }

        /// <summary>
        /// มัธยมศึกษา  
        /// </summary>
        public HasAndCount HighSchool { get; set; }

        /// <summary>
        /// ปวช./ปวส 
        /// </summary>
        public HasAndCount Vocational { get; set; }

        /// <summary>
        /// อุดมศึกษา  
        /// </summary>
        public HasAndCount HigherEducation { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int? PersonnelCount { get; set; }


    }
}