using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class AspNetRoleInfrastructureModel
    {
        public string Id { get; set; }
        public string Name { get; set; }        
    }

    public class Previlege
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
