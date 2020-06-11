using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class UserNotificationAggregate
    {
        public string UserId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public List<UserNotificationModel> UserNotificationModels  { get; set; }

    }

    
    public class UserNotificationModel
    {
        public int Id { get; set; }
        public List<UserActivity> UserActivities  { get; set; }

    }

    public class UserActivity
    {
        public int Id { get; set; }
        [System.ComponentModel.DefaultValue(false)]
        public bool IsSelected { get; set; }
    }
}
