using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
   public class UserDomainModel
    {
    }

    public class UserStatusChangeDomainModel
    {
        public int OrgId { get; set; }
        public string UserId { get; set; }
        public int Status { get; set; }
    }
}
