using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class FileTypeApplicationModel
    {
        public List<IntellmixFileTypes> FileTypes { get; set; }
    }

    public class IntellmixFileTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class FileTypeDetailsApplicationModel
    {       
        public FileTypeDetails FileTypeDetails { get; set; }
    }

    public class FileTypeDetails
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public int? FileId { get; set; }
        public int? LocationId { get; set; }
        public int? DataFrequencyId { get; set; }
        public int? BrandLevelId { get; set; }
        public int? ChannelLevelId { get; set; }
        public int? ErrorThreshold { get; set; }
        public List<OrganisationFileTypeDetailsApplicationModel> OrganisationFileTypeDetails { get; set; }
    }

    public class OrganisationFileTypeDetailsApplicationModel
    {
        public int Id { get; set; }        
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public bool? Nullable { get; set; }
    }

    public class OrganisationFileTypeDetails
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int FileId { get; set; }
        public string FileTypeName { get; set; }
        public int LocationId { get; set; }
        public int DataFrequencyId { get; set; }
        public int BrandLevelId { get; set; }
        public int ChannelLevelId { get; set; }
        [Range(0, 100, ErrorMessage = "Error threshold must between 0 to 100")]
        public int ErrorThreshold { get; set; }
        [Required]
        public List<OrganisationFileTypeDetailsApplicationModel> OrganisationFileTypeColumnsDetails { get; set; }
    }

    public class SampleFileFormatDetail
    {
        public DataTable sampleFileColumns { get; set; }
    }

    public class FileTypesApplicationModel
    {
        public List<FileTypes> FileTypes { get; set; }
    }

    public class FileTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFileUploaded { get; set; }
        public bool IsDueDateApproaching { get; set; }
        public bool HasDueDateExceeded { get; set; }
    }
}
