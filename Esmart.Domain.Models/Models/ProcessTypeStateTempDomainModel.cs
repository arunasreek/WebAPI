using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class ProcessTypeStateTempDomainModel
    {
        public int Id { get; set; }        
        public int FileTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public int ProcessStateId { get; set; }
        public int ProcessTypeId { get; set; }
        public bool IsUsed { get; set; }

    }
}
