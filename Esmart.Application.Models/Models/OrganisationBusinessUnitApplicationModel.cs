using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class OrganisationBusinessUnitApplicationModel
    {
        public List<OrganisationBusinessUnits> OrganisationBusinessUnits { get; set; }

    }

    public class OrganisationBusinessUnits
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public string BUName { get; set; }
        
    }


    public class BusinessUnitFileDetailsApplicationModel
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public string BUName { get; set; }
        public List<BUFilesAssociated> BuFiles { get; set; }
    }

    public class BUFilesAssociated
    {
        public string FileName { get; set; }
        public int FileId { get; set; }
    }
    
}
