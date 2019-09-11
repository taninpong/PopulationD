using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class Package
    {
        /// <summary>
        /// ชนิดของบรรจภุัณฑ์ 
        /// </summary>
        // TODO:
        public string Name { get; set; }

        /// <summary>
        /// ขนาดของภาชนะ 
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// จำนวนที่ซื้อต่อเดือน เพื่ออุปโภคบริโภค  
        /// </summary>
        public string Drink { get; set; }

        /// <summary>
        /// จำนวนที่ซื้อต่อเดือน เพื่อทำเกษตร 
        /// </summary>        
        public string Agriculture { get; set; }
        
        /// <summary>
        /// จำนวนที่ซื้อต่อเดือน เพื่อผลิตสินค้า  
        /// </summary>
        public string Factory { get; set; }

        /// <summary>
        /// จำนวนที่ซื้อต่อเดือน เพื่อการบริการ
        /// </summary>
        public string Service { get; set; }
    }
}