using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class DataPreparationApprovalInfrastructureModel
    {
        public string ApprovedBy { get; set; }
        public DateTime? ApprovalRejectionDateTime { get; set; }
        public int BusinessUnitId { get; set; }
        public string BusinessUnit { get; set; }
        public Guid DataPreperationGroupId { get; set; }
        public string RejectedBy { get; set; }
        public string RejectionReason { get; set; }
        public bool PreETLStatus { get; set; }
        public string PreETLRemarks { get; set; }
    }
}
