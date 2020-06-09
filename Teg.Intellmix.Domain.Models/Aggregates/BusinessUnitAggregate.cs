using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class BusinessUnitAggregate
    {
        public int BUId { get; set; }
        public Nullable<int> OrgId { get; set; }
        public string BUName { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public List<BusinessUnitFile> BusinessUnitFile  { get; set; }

    }

    public class BusinessUnitFile
    {
        
        public Nullable<int> OrgFileId { get; set; }
        public string FileTypeName { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        
    }


}
