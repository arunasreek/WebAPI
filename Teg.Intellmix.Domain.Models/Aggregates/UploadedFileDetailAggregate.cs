using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class UploadedFileDetailAggregate
    {
        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public int BusinessUnitId { get; set; }
        public int OrganisationCycleId { get; set; }
        public int OrganisationFileId { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsFileDiscarded { get; set; }
    }
}
