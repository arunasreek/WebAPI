using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class BusinessUnitDomainBasicModel
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string BUName { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        
        
    }

    public class BusinessUnitDomainModel
    {
        public int Id { get; set; }
        public Nullable<int> OrgId { get; set; }
        public string BUName { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public List<BusinessUnitFileDomainModel> BusinessUnitFile { get; set; }

    }

    public class BusinessUnitFileDomainModel
    {
        public int Id { get; set; }
        public Nullable<int> OrgBUId { get; set; }
        public Nullable<int> OrgFileId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        

    }
}
