using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class SubscriptionApplicationModel
    {
        public List<Subscriptions> Subscriptions { get; set; }
       
    }

    public class Subscriptions
    {
        public int Id { get; set; }
        public string Period { get; set; }
    }
}
