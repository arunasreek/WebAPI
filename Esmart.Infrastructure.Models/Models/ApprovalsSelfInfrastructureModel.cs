using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class ApprovalsInfrastructureModel
    {    
        public int Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }        
        public string FileTypeName { get; set; }
        public string UploadedFileName { get; set; }
        public string BusinessUnit { get; set; }
        public int ApprovalStatus { get; set; }
        public string UploadedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string RejectedBy { get; set; }
    }
}
