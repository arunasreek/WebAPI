using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class UploadedFileDetailApplicationModel
    {
        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public int BusinessUnitId { get; set; }
        public int OrganisationCycleId { get; set; }
        public int OrganisationFileId { get; set; }
        public string FilePath { get; set; }       
    }

    public class UploadedFileDetailResultModel
    {
        public int UploadedFileDetailId { get; set; }
    }
}
