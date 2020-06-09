using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class FileApprovalStatusAggregate
    {
        public int Id { get; set; }
        public int UploadedFileId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public bool IsApproved { get; set; }
        public bool IsRejected { get; set; }
        public string RejectionRemarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
