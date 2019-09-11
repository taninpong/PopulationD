using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{

    public enum FactorialCategory
    {
        /// <summary>
        /// การผลิตผลิตภัณฑ์อาหาร 
        /// </summary>
        Food = 1,
        /// <summary>
        /// การผลิตเครื่องดื่ม 
        /// </summary>
        Drink = 2,
        /// <summary>
        /// การผลิตผลิตภัณฑ์ยาสูบ
        /// </summary>
        Smoke = 3,
        /// <summary>
        /// การผลิตสิ่งทอ
        /// </summary>
        Fabric = 4,
        /// <summary>
        /// การผลิตเสื้อผ้าเครื่องแต่งกาย
        /// </summary>
        Costume = 5,
        /// <summary>
        /// การผลิตเครื่องหนังและผลิตภัณฑ์ที่เกี่ยวข้อง
        /// </summary>
        Leather = 6,
        /// <summary>
        /// การผลิตไม้และผลิตภัณฑ์จากไม้และไม้ก๊อก (ยกเว้นเฟอร์นิเจอร์) การผลิตสิ่งของจากฟางและวัสดุถักสานอื่นๆ
        /// </summary>
        Wood = 7,
        /// <summary>
        /// การผลิตกระดาษและผลิตภัณฑ์กระดาษ
        /// </summary>
        Paper = 8,
        /// <summary>
        /// การพิมพ์และการผลิตซ้ำสื่อบันทึกข้อมูล 
        /// </summary>
        Media = 9,
        /// <summary>
        /// การผลิตถ่านโค้กและผลิตภัณฑ์จากการกลั่นปิโตรเลียม
        /// </summary>
        Coal = 10,
        /// <summary>
        /// การผลิตเคมีภัณฑ์และผลิตภัณฑ์เคมี
        /// </summary>
        Chemical = 11,
        /// <summary>
        /// การผลิตเภสัชภัณฑ์ เคมีภัณฑ์ที่ใช้รักษาโรคและผลิตภัณฑ์จากพืชและสัตว์ที่ใช้รักษาโรค
        /// </summary>
        Pharmacy = 12,
        /// <summary>
        /// การผลิตผลิตภัณฑ์ยางและพลาสติก 
        /// </summary>
        RubberPlastic = 13,
        /// <summary>
        /// การผลิตผลิตภัณฑ์อื่นๆที่ทำจากแร่อโลหะ
        /// </summary>
        NonMetal = 14,
        /// <summary>
        /// การผลิตโลหะขั้นมูลฐาน 
        /// </summary>
        BaseMetal = 15,
        /// <summary>
        /// การผลิตผลิตภัณฑ์ที่ทำจากโลหะประดิษฐ์ (ยกเว้นเครื่องจักรและอุปกรณ์)
        /// </summary>
        ArtificialMetal = 16,
        /// <summary>
        /// การผลิตผลิตภัณฑ์คอมพิวเตอร์อิเล็กทรอนิกส์ และอุปกรณ์ที่ใช้ในทางทัศนศาสตร์
        /// </summary>
        Computer = 17,
        /// <summary>
        /// การผลิตอุปกรณ์ไฟฟ้า
        /// </summary>
        Electricity = 18,
        /// <summary>
        /// การผลิตเครื่องจักรและเครื่องมือ ซึ่งมิได้จัดประเภทไว้ในที่อื่น
        /// </summary>
        Machine = 19,
        /// <summary>
        /// การผลิตยานยนต์ รถพ่วง กึ่งรถพ่วง
        /// </summary>
        Trailer = 20,
        /// <summary>
        /// การผลิตอุปกรณ์ขนส่งอื่นๆ
        /// </summary>
        TransportEquipment = 21,
        /// <summary>
        /// การผลิตเฟอร์นิจอร์
        /// </summary>
        Furniture = 22,
        /// <summary>
        /// การผลิตผลิตภัณฑ์ประเภทอื่นๆ
        /// </summary>
        OtherProducts = 23,
        /// <summary>
        /// การซ่อมและการติดตั้งเครื่องจักรและอุปกรณ์ 
        /// </summary>
        RepairInstallation = 24,
        /// <summary>
        /// การจัดการน้ำเสีย 
        /// </summary>
        WastewaterManagement = 25,
        /// <summary>
        /// การเก็บรวบรวมของเสีย การบำบัด และการกำจัดของเสีย รวมถึงการนำของเสียกลับมาใช้ใหม่ 
        /// </summary>
        Collection = 26,
        /// <summary>
        /// กิจกรรมการบำบัดและบริการจัดการของเสียอื่นๆ 
        /// </summary>
        Treatment = 27,
        /// <summary>
        /// การทำเหมืองถ่านหินและลิกไนต์ 
        /// </summary>
        CoalLignite = 28,
        /// <summary>
        /// การทำเหมืองสินแร่โลหะ 
        /// </summary>
        MetalOreMining = 29,
        /// <summary>
        /// การทำเหมืองแร่และเหมืองหินอื่นๆ 
        /// </summary>
        OtherMining = 30,
    }
}