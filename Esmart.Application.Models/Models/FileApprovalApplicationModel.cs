using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class FileApprovalApplicationModel
    {
        public List<ApprovalModel> FileActions { get; set; }
    }

   
    public class ApprovalModel
    {
        public int FileId { get; set; }
        public int FileState { get; set; }
        public string Remarks { get; set; }
        public int ProcessState { get; set; }

    }
}
