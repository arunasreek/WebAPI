using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class RoleDetailsDomainModel
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public List<PrevilegesDomainModel> PrevilegesDomainModels { get; set; }
    }

    public class PrevilegesDomainModel
    {
        public int Id { get; set; }
        public string Previlege { get; set; }
    }
}
