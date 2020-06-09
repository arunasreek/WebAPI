using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class UserDashboardDetailAggregate
    {
        public string UserId { get; set; }
        public List<UserDashboardAggregate> UserDashboards { get; set; }
        public List<UserChannelAggregate> UserChannels { get; set; }
        public List<UserKPIAggregate> UserKPIs { get; set; }
    }

    public class UserDashboardAggregate
    {
        public int Id { get; set; }    
        public int DashboardId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public class UserChannelAggregate
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public class UserKPIAggregate
    {
        public int Id { get; set; }
        public int KPIId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
