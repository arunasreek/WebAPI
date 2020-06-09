using System;

namespace Esmart.Infrastructure.Models
{
    public class SubscriptionInfrastructureModel
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
