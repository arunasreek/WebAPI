using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class ProcessStatusResultModel
    {
        public ProcessStatusApplicationModel ProcessStatus { get; set; }
    }

    public class ProcessStatusApplicationModel
    {
        public List<FileUploadApplicationModel> FileUpload { get; set; }
        public List<FileApprovedApplicationModel> FileApproved { get; set; }
        public DataPrepartionApplicationModel DataPrepartion { get; set; }
        public ReportsApplicationModel Reports { get; set; }
    }

    public class FileUploadApplicationModel
    {
        public int? FileUploadedId { get; set; }
        public int OrganisationFileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public string Owner { get; set; }
        public FileUploadProcessStatus FileUploadProcessStatus { get; set; }
    }

    public class FileApprovedApplicationModel
    {
        public int? FileUploadedId { get; set; }
        public int OrganisationFileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public string Owner { get; set; }
        public FileApprovedProcessStatus FileApprovedProcessStatus { get; set; }
    }

    public class DataPrepartionApplicationModel
    {
        public string Owner { get; set; }
        public DataPrepartionProcessStatus DataPrepartionProcessStatus { get; set; }
    }

    public class ReportsApplicationModel
    {
        public string Owner { get; set; }
        public ReportsProcessStatus ReportsProcessStatus { get; set; }
    }

    public class FileUploadProcessStatus
    {
        public int? Status { get; set; }
        public string DueDate { get; set; }
        public DateTime? UpdateDate { get; set; }        
    }

    public class FileApprovedProcessStatus
    {
        public int? Status { get; set; }
        public string DueDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }

    public class ProcessStatusBarResultModel
    {
        public ProcessStatusBarApplicationModel ProcessStatusBar { get; set; }
    }

    public class ProcessStatusBarApplicationModel
    {
        public bool IsFilesUploadDone { get; set; }
        public bool IsFilesApprovedDone { get; set; }
        public bool IsDataPreparationDone { get; set; }
        public bool IsReportsDone { get; set; }
    }

    public class ProcessStatusLogResultModel
    {
        public List<ProcessStatusLogApplicationModel> ProcessStatusLog { get; set; }
    }

    public class ProcessStatusLogApplicationModel
    {
        public string FileStatus { get; set; }
        public string Name { get; set; }
        public string Timestamp { get; set; }
    }

    public class DataPrepartionProcessStatus
    {
        public int? Status { get; set; }
        public string DueDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }

    public class ReportsProcessStatus
    {
        public int? Status { get; set; }
        public string DueDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
