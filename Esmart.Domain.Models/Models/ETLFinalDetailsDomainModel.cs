using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class ETLFinalDetailsDomainModel
    {        
        public string ETLFileGroupId { get; set; }
        public int OrgID { get; set; }
        public int OrgBUId { get; set; }
        public string FilePath { get; set; }
    }
}
