using System;
using System.Collections.Generic;
using System.Text;

namespace WebManageApi.AnalyticFunction.Models
{
    public class RevertEaInfo
    {
        public bool IsPreview { get; set; }
        public string ChainId { get; set; }
        public List<RevertEaLog> EaLogs { get; set; }
    }

    public class RevertEaLog
    {
        public string EaCode { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Subdistrict { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> FiMoney { get; set; }
        public IEnumerable<string> FsMoney { get; set; }
    }
}
