using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class OrganisationFileTypeAggregate
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
        public List<OrganisationFileTypeDetailsDomainModelAggregate> OrganisationFileTypeColumnsDetails { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }

    public class OrganisationFileTypeDetailsDomainModelAggregate
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public bool? Nullable { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
