using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class OrganisationFileTypeInfrastructureModel
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public int? FileId { get; set; }
        public int? LocationId { get; set; }
        public int? DataFrequencyId { get; set; }
        public int? BrandLevelId { get; set; }
        public int? ChannelLevelId { get; set; }
        public int? ErrorThreshold { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string FileTypeName { get; set; }
    }

    public class FileTypeDetailsInfrastructureModel
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public int? FileId { get; set; }
        public int? LocationId { get; set; }
        public int? DataFrequencyId { get; set; }
        public int? BrandLevelId { get; set; }
        public int? ChannelLevelId { get; set; }
        public int? ErrorThreshold { get; set; }
        public List<OrganisationFileTypeDetailsInfrastructureModel> OrganisationFileTypeDetailsInfrastructureModel { get; set; }

    }

    public class OrganisationFileTypeDetailsInfrastructureModel
    {
        public int Id { get; set; }
        public int? OrgFileId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public bool? Nullable { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modifieddate { get; set; }
    }

    public class FileTypeDetailsSampleFormatInfrastructureModel
    {
        public int Id { get; set; }
        public int? OrgFileId { get; set; }    
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
    }

    public class OrganisationFileTypeCountInfrastructureModel
    {
        public int UploadedFileDetailId { get; set; }
        public int UploadedFileRevisionId { get; set; }
        public string BusinessUnit { get; set; }
    }

    //for fileupload screen
    public class FileTypesInfrastructureModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFileUploaded { get; set; }
        public bool IsDueDateApproaching { get; set; }
        public bool HasDueDateExceeded { get; set; }
    }
}
