using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{    
    public class UserColumMappingDomainModel
    {
        public int OrganisationId { get; set; }
        public int BusinessUnitId { get; set; }
        public int OrganisationCycleId { get; set; }
        public int OrganisationFileId { get; set; }
        public List<UserColumMappingsDomainModel> UserColumMappingDetails { get; set; }
    }

    public class UserColumMappingsDomainModel
    {
        public int Id { get; set; }
        public string ColumName { get; set; }
        public string MatchedColumnName { get; set; }        
        public int UploadedFileId { get; set; }
    }
}
