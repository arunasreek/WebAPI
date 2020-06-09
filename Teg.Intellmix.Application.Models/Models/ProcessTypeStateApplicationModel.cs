using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class ProcessTypeStateApplicationModel
    {
        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public int FileTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public int ProcessStateId { get; set; }
        public int ProcessTypeId { get; set; }
    }
}
