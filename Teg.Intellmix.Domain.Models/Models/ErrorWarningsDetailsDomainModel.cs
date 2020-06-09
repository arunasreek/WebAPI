using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class ErrorWarningsDetailsDomainModel
    {
        public List<DataTypeValidationLogDomainModel> DataTypeValidationLog { get; set; }
        public List<DuplicateValueLogDomainModel> DuplicateValueLog { get; set; }
        public List<MissingValueLogDomainModel> MissingValueLog { get; set; }
    }

    public class DuplicateValueLogDomainModel
    {
        public Guid SetId { get; set; }
        public int UpdateMode { get; set; }
        public int FileRevisionId { get; set; }
    }

    public class MissingValueLogDomainModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public string ColumnName { get; set; }      
        public int ActionType { get; set; }        
    }
}
