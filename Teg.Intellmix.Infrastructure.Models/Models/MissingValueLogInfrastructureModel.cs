using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class MissingValueLogInfrastructureModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public int DataCheckMasterId { get; set; }
        public string DataCheckType { get; set; }
        public int CautionTypeId { get; set; }
        public string CautionType { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public int NoOfMissingValues { get; set; }
        public bool IsNullable { get; set; }
        public decimal? Mean { get; set; }
        public decimal? Median { get; set; }
        public decimal? Mode { get; set; }
    }
}
