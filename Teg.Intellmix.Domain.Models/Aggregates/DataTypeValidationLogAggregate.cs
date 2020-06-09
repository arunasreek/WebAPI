using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class DataTypeValidationLogAggregate
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public int DataCheckMasterId { get; set; }
        public string DataCheckType { get; set; }
        public int CautionTypeId { get; set; }
        public string CautionType { get; set; }
        public string ColumnName { get; set; }
        public int RowNumber { get; set; }
        public string CurrentData { get; set; }
        public string ExpectedDataType { get; set; }
        public string DataEngineTableRecordId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
