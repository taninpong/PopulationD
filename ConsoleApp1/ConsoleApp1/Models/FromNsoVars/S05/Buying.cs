using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    ///  น้ำที่ซื้อมาใช้    ***แสดงข้อมูล ชนิดพืช/การผลิต/การบริการ ที่เลือกใช้น้าฝนที่กักเก็บไว้ จากตอนที่ 1-4
    /// </summary>
    // TODO: 
    public class Buying
    {
        /// <summary>
        /// น้้าที่ซื้อมาใช้ มีบรรจุภัณฑ์ชนิดใดบ้าง มีขนาดบรรจุเท่าใด และโดยเฉลี่ยต่อเดือนแล้วซื้อมาเพื่อใช้ในแต่ ละกิจกรรมเป็นจ้านวนเท่าไร 
        /// </summary>
        public List<Package> Package { get; set; }
    }
}