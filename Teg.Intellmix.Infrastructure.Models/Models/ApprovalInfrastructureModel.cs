using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class ApprovalInfrastructureModel
    {
        public int ApprovalStatus { get; set; }
        public string ApprovedBy { get; set; }
        public int BusinessUnitId { get; set; }
        public string BusinessUnit { get; set; }
        public string FileTypeName { get; set; }
        public string RejectedBy { get; set; }
        public string RejectionReason { get; set; }
        public string UpdatedBy { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public string UploadedFileName { get; set; }
        public DateTime? UpdateDate { get; set; }
        
    }
    
}
