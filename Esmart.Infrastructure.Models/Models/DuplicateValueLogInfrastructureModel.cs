using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
   public class DuplicateValueLogInfrastructureModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public int DataCheckMasterId { get; set; }
        public string DataCheckType { get; set; }
        public int CautionTypeId { get; set; }
        public string CautionType { get; set; }
        public long FileRowId { get; set; }
        public long DuplicateFileRowId { get; set; }
        public Guid RecordId { get; set; }
        public Guid DuplicateRecordId { get; set; }
        public bool IsRecordValid { get; set; }
    }
}
