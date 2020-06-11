using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    //public class UserNotificationDomainModel
    //{
    //    public List<UserNotificationModel> NotificationModels { get; set; }
    //}

    public class UserNotificationDomainModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserNotificationActivityDomain> UserNotificationActivities { get; set; }

    }

    public class UserNotificationActivityDomain
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        [System.ComponentModel.DefaultValue(false)]
        public bool IsSelected { get; set; }
    }
}
