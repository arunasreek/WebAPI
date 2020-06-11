using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class FileApprovalStatusApplicationModel
    {
        public int Id { get; set; }
        [Required]
        public int UploadedFileId { get; set; }
        [Required]
        public int UploadedFileRevisionNo { get; set; }
        public bool IsApproved { get; set; }
        public bool IsRejected { get; set; }
        public string RejectionRemarks { get; set; }
    }
}
