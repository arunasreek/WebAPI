using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{        
    public class AspNetUserRoleInfrastructureModel
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public List<RolePrevilegeInfrastructureModel> rolePrevileges { get; set; }
    }

    public class RolePrevilegeInfrastructureModel
    {
        public int Id { get; set; }
        public string Previlege { get; set; }
    }
}
