using System;
using System.Collections.Generic;
using mdl = NSOWater.HotMigration.Models;

namespace NSOWater.HotMigration.HotModels
{
    public class User : mdl.ModelBase
    {
        /// <summary>
        /// คำนำหน้าชื่อ
        /// </summary>
        public string TitleName { get; set; }

        /// <summary>
        /// ชื่อ
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// สกุล
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// เลขบัตรประชาชน
        /// </summary>
        public string IDCard { get; set; }

        /// <summary>
        /// อีเมล
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// เบอร์โทร
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// รหัสจังหวัด
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// ประเภทผู้ใช้
        /// </summary>
        public int UserType { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// เลขบัญชีธนาคาร
        /// </summary>
        public string BankAccountNo { get; set; }

        /// <summary>
        /// ประเภทบัญชีธนาคาร
        /// </summary>
        public string BankAccountType { get; set; }

        /// <summary>
        /// ชื่อบัญชี(ถ้าไม่มีเหมือนชื่อตัว)
        /// </summary>
        public string BankAccountHolderName { get; set; }

        /// <summary>
        /// ชื่อธนาคาร
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// สาขา
        /// </summary>
        public string BankBranchName { get; set; }

        /// <summary>
        /// บ้านเลขที่
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// ถนน
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// ตำบล
        /// </summary>
        public string SubDistrict { get; set; }

        /// <summary>
        /// อำเภอ
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// จังหวัด
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// รหัสไปรษณีย์
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// สถานะการเปิด-ปิด การใช้งาน
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// วันที่เลิกใช้งาน (ลบ) ผู้ใช้งานคนนี้
        /// </summary>
        public DateTime? DeletionDateTime { get; set; }

        /// <summary>
        /// List EA Code
        /// </summary>
        public List<string> EACodes { get; set; }

        /// <summary>
        /// Reports To which FS? (for FI)
        /// </summary>
        public List<string> ReportsTo { get; set; }
    }
}
