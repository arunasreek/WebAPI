using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class ApprovalsModel
    {
        public PendingApprovals  pendingApprovals { get; set; }
        public CompletedApprovals  completedApprovals { get; set; }
    }

    public class PendingApprovals
    {
        public List<ApprovalApplicationModel> FileApprovals { get; set; }
        public List<DataPrepartionApprovalApplicationModel> DataPrepartionApprovals { get; set; }
        public List<ReportsApprovalApplicationModel>   reportsApprovals{ get; set; }
    }

    public class CompletedApprovals
    {
        public List<ApprovalApplicationModel> FileApprovals { get; set; }
        public List<DataPrepartionApprovalApplicationModel> DataPrepartionApprovals { get; set; }
        public List<ReportsApprovalApplicationModel> reportsApprovals { get; set; }
    }

    public class ApprovalApplicationModel
    {
        public int ApprovalStatus { get; set; }
        public string ApprovedBy { get; set; }
        public int BusinessUnitId { get; set; }
        public string BusinessUnit { get; set; }
        public string FileTypeName { get; set; }
        public string RejectedBy { get; set; }
        public string RejectionReason { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public string UploadedFileName { get; set; }
          
    }

    public class DataPrepartionApprovalApplicationModel
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

    public class ReportsApprovalApplicationModel
    {
        public string ApprovedBy { get; set; }
        public DateTime? ApprovalRejectionDateTime { get; set; }
        public string BusinessUnit { get; set; }
        public Guid ETLGroupId { get; set; }
        public int BusinessUnitId { get; set; }
        public string RejectedBy { get; set; }
        public string RejectionReason { get; set; }
    }

    // New Model

    public class ApprovalsApplicationModel
    {
        public PendingApprovals pendingApprovals { get; set; }
        public CompletedApprovals completedApprovals { get; set; }
    }

   
}
