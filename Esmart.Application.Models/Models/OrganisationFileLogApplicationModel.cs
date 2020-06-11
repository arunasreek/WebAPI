using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class OrganisationFileLogApplicationModel
    {
        public List<OrganisationFileLog> OrganisationFileLogDetails { get; set; }
    }

    public class OrganisationFileLog
    {
        public int Id { get; set; }        
        public int VersionNo { get; set; }
        public string UploadBy { get; set; }
        public string UploadDateTime { get; set; }
        public int WarningsCount { get; set; }
    }

    public class OrganisationFileLogDownload
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string FileTypeName { get; set; }
        public int VersionNo { get; set; }      
        public string Period { get; set; }
        public string BussinessUnit { get; set; }
    }
}
