using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class DataTypeValidationLogApplicationModel
    {
        public Guid Id { get; set; }
        [Required]
        public int UploadedFileDetailsId { get; set; }
        [Required]
        public int UploadedFileRevisionNo { get; set; }       
        public int DataCheckMasterId { get; set; }        
        public string DataCheckType { get; set; }       
        public int CautionTypeId { get; set; }      
        public string CautionType { get; set; }
        [Required]
        public string ColumnName { get; set; }
        [Required]
        public int RowNumber { get; set; }
        [Required]
        public string CurrentData { get; set; }
        [Required]
        public string ExpectedDataType { get; set; }
        [Required]
        public string DataEngineTableRecordId { get; set; }
    }
}
