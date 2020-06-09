using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class FileProcessingStateInfrastructureModel
    {
        public int Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public bool ColumnCountValid { get; set; }
        public bool UploadStarted { get; set; }
        public bool UploadComplete { get; set; }
        public bool EngineColumnMappingDone { get; set; }
        public bool UserColumnMappingDone { get; set; }
        public bool InProcess { get; set; }
        public bool ProcessComplete { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public int ErrorCount { get; set; }
        public int WarningCount { get; set; }
        public bool IsFileApproved { get; set; }
        public bool IsStateValid { get; set; }
        public bool IsProcessValid { get; set; }
        public string Remarks { get; set; }
        public string FileTypeName { get; set; }
        public bool IsFileRejected { get; set; }
    }
}
