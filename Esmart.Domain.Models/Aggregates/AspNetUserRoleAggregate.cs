using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class AspNetUserRoleAggregateModel
    {
        public string UserId { get; set; }
        public int OrgId { get; set; }
        public List<AspNetUserRoleAggregate> Roles { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }      
    }

    public class AspNetUserRoleAggregate
    {        
        public string RoleId { get; set; }
        public bool IsActive { get; set; }
    }
}
