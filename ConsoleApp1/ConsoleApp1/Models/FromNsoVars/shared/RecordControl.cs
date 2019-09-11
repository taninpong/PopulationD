using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// Record Control for Manage the Sample Record
    /// </summary>
    public class RecordControl
    {
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? DeletedDateTime { get; set; }

        public DateTime? LastUpload { get; set; }
        public DateTime? LastDownload { get; set; }
        public int? LogCount { get; set; }
        public List<RecordControlLog> Logs { get; set; }
    }
}
