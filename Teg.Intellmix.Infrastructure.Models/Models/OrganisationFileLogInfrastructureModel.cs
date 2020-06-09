using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class OrganisationFileLogInfrastructureModel
    {
        public int Id { get; set; }
        public int UploadedFileId { get; set; }        
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public int VersionNo { get; set; }
        public string UploadBy { get; set; }
        public string UploadDateTime { get; set; }
        public int WarningsCount { get; set; }
    }
}
