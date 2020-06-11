using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class FileGroupAggregate
    {
        public Guid Id { get; set; }
        public int BusinessUnitId { get; set; }
        public int PeriodId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }        
        public int GroupStatus { get; set; }
        public List<FileGroupDetailAggregate> FileGroupDetailAggregateList { get; set; }
    }

    public class FileGroupDetailAggregate
    {
        public Guid FileGroupId { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int RevisionNo { get; set; }
        public string FileTypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }       
    }
}
