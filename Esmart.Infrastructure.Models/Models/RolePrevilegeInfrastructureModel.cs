using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models
{   
    public class RolePrevilegeInfrastructureModel
    {
        public int Id { get; set; }
        public int PrevilegeId { get; set; }
        public string Previlege { get; set; }
    }
}
