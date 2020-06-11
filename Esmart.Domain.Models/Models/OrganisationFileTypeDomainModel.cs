using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Resources;

namespace Esmart.Domain.Models.Models
{
    public class FileTypeDomainModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class OrganisationFileTypeDomainModel
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int FileId { get; set; }
        public string FileTypeName { get; set; }
        public int LocationId { get; set; }
        public int DataFrequencyId { get; set; }
        public int BrandLevelId { get; set; }
        public int ChannelLevelId { get; set; }        
        public int ErrorThreshold { get; set; }      
        public List<OrganisationFileTypeDetailsDomainModel> OrganisationFileTypeColumnsDetails { get; set; }      
    }

    public class OrganisationFileTypeDetailsDomainModel
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public bool? Nullable { get; set; }           
    }
}
