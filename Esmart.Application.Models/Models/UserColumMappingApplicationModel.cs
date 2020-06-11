using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class UserColumMappingApplicationModel
    {
        public int OrganisationId { get; set; }
        public int UploadedFileId { get; set; }
        public int BusinessUnitId { get; set; }
        public int OrganisationCycleId { get; set; }
        public int OrganisationFileId { get; set; }
        public List<UserColumMapping> UserColumMappingDetails { get; set; }        
    }

    public class UserColumMapping
    {
        public int Id { get; set; }
        public string ColumName { get; set; }
        public string MatchedColumnName { get; set; }       
        
    }   
}
