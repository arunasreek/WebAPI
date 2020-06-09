using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class ErrorWarningsDetailsAggregate
    {
        public List<DataTypeValidationLogAggregate> DataTypeValidationLog { get; set; }
        public List<DuplicateValueLogAggregate> DuplicateValueLog { get; set; }
        public List<MissingValueLogAggregate> MissingValueLog { get; set; }
    }

    public class DuplicateValueLogAggregate
    {
        public Guid SetId { get; set; }
        public int UpdateMode { get; set; }
        public int FileRevisionId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public class MissingValueLogAggregate
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public string ColumnName { get; set; }
        public int ActionType { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
