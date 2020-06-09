using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
   public class UserBUFileAccessInfrastructureModel
    {
        
        public int BusinessUnitId { get; set; }
        public int OrganisationId { get; set; }
        public int FileId { get; set; }
        public string UserId { get; set; }
    }

   
}
