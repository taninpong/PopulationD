using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// รหัสการเข้าพบยูนิตย่อย
    /// </summary>
    public enum Access 
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
        /// 4 บ้าน/อาคารว่าง
        /// </summary>
        Vacancy = 4,
        /// <summary>
        /// 5 บ้านร้าง  
        /// </summary>
        AbandonedHouse = 5,
        /// <summary>
        /// 6 ไม่สามารถเก็บข้อมูลต่อได้ 
        /// </summary>
        CanNotContinue = 6,
    }
}