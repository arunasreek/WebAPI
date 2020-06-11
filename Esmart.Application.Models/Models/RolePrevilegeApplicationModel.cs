using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class RolePrevilegeApplicationModel
    {
        public List<RolePrevilege> RolePrevileges { get; set; }
    }

    public class RolePrevilege
    {
        public int Id { get; set; }
        public int PrevilegeId { get; set; }
        public string Previlege { get; set; }
    }
}
