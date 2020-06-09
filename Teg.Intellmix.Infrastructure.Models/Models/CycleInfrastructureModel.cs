using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class CycleInfrastructureModel
    {
        public int Id { get; set; }
        public string DataCycle { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? eModifiedDate { get; set; }
    }

    
}
