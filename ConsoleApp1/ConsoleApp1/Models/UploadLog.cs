using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebManageAPI.Function
{
    public class UploadLog
    {
        /// <summary>
        /// Session Id
        /// </summary>
        public string _id { get; set; }
        public string UserId { get; set; }
        /// <summary>
        /// ชื่อ container ที่ผู้สำรวจส่งไฟล์ขึ้นมา (C1)
        /// </summary>
        public string ContainerName { get; set; }
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// วันเวลาที่ถูกนำไปประมวลผล Migration (ย้ายข้อมูลจาก c1 > c2)
        /// </summary>
        public DateTime? RunMigrationCompletedDateTime { get; set; }
        public DateTime? RunBlob2DatabaseCompletedDateTime { get; set; }
        public DateTime? UploadCompletedDate { get; set; }
        public DateTime? UploadAutoCompletedDate { get; set; }
        public DateTime? DownloadRequestDate { get; set; }
        public DateTime? DownloadCompletedDate { get; set; }
        public DateTime? ValidateStorageDate { get; set; }
        public bool? IsStorageValid { get; set; }
        public DateTime? Retry1 { get; set; }
        public DateTime? Retry2 { get; set; }
        public DateTime? Retry3 { get; set; }
    }
}
