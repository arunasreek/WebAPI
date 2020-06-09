using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class AspNetUserRoleDomainModel
    {
        public string UserId { get; set; }
        public int OrganisationId { get; set; }
        public List<AspNetUserRoleDomain> AspNetUserRoles { get; set; }
    }

    public class AspNetUserRoleDomain
    {        
        public string RoleId { get; set; }
        public bool IsActive { get; set; }
    }
}
