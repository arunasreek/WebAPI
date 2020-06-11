using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models
{
    public class BusinessUnitInfrastructureModel
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public string BUName { get; set; }
        
    }

    public class BusinessUnitFileDetailsInfrastructureModel
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public string BUName { get; set; }
        public List<BUFilesAssociated> BuFiles { get; set; }
    }

    public class BUFilesAssociated
    {
        public string FileName { get; set; }
        public int FileId { get; set; }
    }
}
