using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class AspNetRolesApplicationModel
    {
        public List<AspNetRole> Roles { get; set; }
    }

    public class AspNetRole
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
