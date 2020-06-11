using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class OutlierLogInfrastructureModel
    {
        public int Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public int DataCheckMasterId { get; set; }
        public string DataCheckType { get; set; }
        public int CautionTypeId { get; set; }
        public string CautionType { get; set; }
        public string ColumnName { get; set; }
        public int RowNo { get; set; }
        public decimal ColumnValue { get; set; }
        public decimal MinRange { get; set; }
        public decimal MaxRange { get; set; }
    }
}
