using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class OrganisationUserPrivilegeAggregate
    {       
        public int OrganisationId { get; set; }
        public string UserId { get; set; }
        public int BusinessUnitId { get; set; }
        public int ProcessStateId { get; set; }
        public int PrivilegeId { get; set; }
        public int? FileId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }   
    }
}
