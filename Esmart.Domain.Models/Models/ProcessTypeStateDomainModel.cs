using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class ProcessTypeStateDomainModel
    {
        public int Id { get; set; }        
        public int FileTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public int ProcessStateId { get; set; }
        public int ProcessTypeId { get; set; }
        public string CreatedBy { get; set; }
    }
}
