using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class RoleAggregate
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public List<PrevilegeAggregate> Previleges { get; set; }
        
    }
    public class PrevilegeAggregate
    {
        public int Id { get; set; }
        public string Previlege { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
    
}
