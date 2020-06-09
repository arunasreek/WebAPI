using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class FileApprovalStatusDomainModel
    {
        public int Id { get; set; }
        public int UploadedFileId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public bool IsApproved { get; set; }
        public bool IsRejected { get; set; }
        public string RejectionRemarks { get; set; }
    }
}
