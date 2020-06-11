using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class UserColumMappingAggregateDetails
    {
        public List<UserColumMappingAggregate> UserColumMappingAggregate { get; set; }
    }

    public class UserColumMappingAggregate
    {
        public int Id { get; set; }
        public string ColumName { get; set; }
        public string MatchedColumnName { get; set; }       
        public int UploadedFileId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
