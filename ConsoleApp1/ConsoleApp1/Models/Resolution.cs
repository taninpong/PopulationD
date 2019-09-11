using System;
using System.Collections.Generic;
using System.Text;

namespace WebManageApi.AnalyticFunction.Models
{
    public class Resolution
    {
        public string _id { get; set; }
        public string SurveyId { get; set; }
        public string BuildingId { get; set; }
        public string Suggestion { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ResolvedDateTime { get; set; }
        public string ResolvedBy { get; set; }
        public bool? IsApproved { get; set; }
        public string ContainerName { get; set; }
        public string BlobName { get; set; }
    }
}
