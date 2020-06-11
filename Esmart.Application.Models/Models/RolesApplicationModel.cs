using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class RolesApplicationModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class RoleDetailsApplicationModel
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public List<Previleges> Previleges { get; set; }
    }

    public class Previleges
    {
        public int Id { get; set; }
        public string Previlege { get; set; }
    }
}
