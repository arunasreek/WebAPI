using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class ETLFileGroupAggregate
    {
        public Int64 Id { get; set; }
        public Guid GroupId { get; set; }
        public int BuId { get; set; }
        public int CycleId { get; set; }
        public bool GroupStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }        
}
