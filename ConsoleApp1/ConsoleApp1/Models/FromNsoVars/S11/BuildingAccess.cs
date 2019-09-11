using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// H1-X การอนุญาตให้เข้าอาคาร
    /// </summary>
    public enum BuildingAccess
    {
        /// <summary>
        /// 1 มีผู้ให้ข้อมูลให้ความร่วมมือ  
        /// </summary>
        HasPersonAndAccept = 1,
        /// <summary>
        /// 2 มีผู้ให้ข้อมูลแต่ไม่ให้ความร่วมมือ  
        /// </summary>
        HasPersonNoAccept = 2,
        /// <summary>
        /// 3 ไม่มี/ไม่พบผู้ให้ข้อมูล  
        /// </summary>
        NoPerson = 3,
        /// <summary>
        /// 4 บ้าน/อาคารว่างหรือร้าง  
        /// </summary>
        Vacancy = 4,
        /// <summary>
        /// 5 ไม่สามารถเก็บข้อมูลต่อได้ 
        /// </summary>
        CanNotContinue = 5
    }
}