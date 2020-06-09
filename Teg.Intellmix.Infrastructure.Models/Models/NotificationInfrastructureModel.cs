using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class NotificationInfrastructureModel
    {
        public int Id { get; set; }
        public string Notification { get; set; }
        public List<NotificationActivityInfrastructureModel> Activity { get; set; }
    }

    public class NotificationActivityInfrastructureModel
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public Nullable<bool> IsSelected { get; set; }
    }
}
