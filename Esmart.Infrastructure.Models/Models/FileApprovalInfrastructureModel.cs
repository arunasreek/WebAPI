using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class FileApprovalInfrastructureModel
    {
        public int OrganisationId { get; set; }
        public string UserId { get; set; }
        public int BUId { get; set; }
        public int FileId { get; set; }
    }
}
