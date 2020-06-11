using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class NotificationApplicationModel
    {
        public List<NotificationModels> Notification { get; set; }
        public List<UserNotificationModel> userNotificationModels { get; set; }
    }

    public class NotificationModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NotificationActivity> NotificationActivities { get; set; }

    }

    public class NotificationActivity
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        [System.ComponentModel.DefaultValue(false)]
        public bool IsSelected { get; set; }
    }

    public class UserNotificationModel
    {
        public int OrganisationId { get; set; }
        public int BUId { get; set; }
        public string BUName { get; set; }
        public int ProcessStateId { get; set; }
        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedDate { get; set; }

    }

    //public class Notifications
    //{
    //    public int Id { get; set; }
    //    public string Notification { get; set; }

    //}

    //public class NotificationActivityApplicationModel
    //{
    //    public List<NotificationActivity> NotificationActivities  { get; set; }

    //}



}
