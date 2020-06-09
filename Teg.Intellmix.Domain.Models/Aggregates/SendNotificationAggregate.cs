using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class SendNotificationAggregate
    {
        public NotificationLogAggregate notificationLog { get; set; }
        public List<NotificationLogAggregate> notificationLogList { get; set; }
        public List<UserNotificationsAggregate> userNotifications { get; set; }
        public List<PushUserNotificationAggregate> pushUserNotificationAggregates { get; set; }
    }

    public class NotificationLogAggregate
    {
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public int PeriodId { get; set; }
        public int FileTypeId { get; set; }
        public int ProcessStateId { get; set; }
        public int NotificationTypeStateId { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class UserNotificationsAggregate
    {
        public int FileTypeId { get; set; }
        public string UserId { get; set; }
        public int NotificationLogId { get; set; }
        public int NotificationMasterId { get; set; }
        public bool IsSeen { get; set; }
        public bool IsSent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class PushUserNotificationAggregate
    {
        public int NotificationId { get; set; }
        public int OrganisationId { get; set; }
        public int BUId { get; set; }
        public string BUName { get; set; }
        public int ProcessStateId { get; set; }
        public int FileTypeId { get; set; }
        public string FileTypeName { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsSeen { get; set; }
    }


}
