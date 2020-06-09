using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class FileLogAggregate
    {
        public int Id { get; set; }
        public int UploadedFileId { get; set; }
        public int RevisionNo { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int VersionNo { get; set; }
    }
}
