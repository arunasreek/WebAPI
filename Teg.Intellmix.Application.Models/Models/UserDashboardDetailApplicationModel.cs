using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class UserDashboardDetail
    {
        public UserDashboardDetailApplicationModel dashboardDetails{get; set;}
    }

    public class UserDashboardDetailApplicationModel
    {
       [Required]
        public string UserId { get; set; }
        public int OrganisationId { get; set; }
        public List<UserDashboard> Dashboards { get; set; }
        public List<UserChannel> Channels { get; set; }
        public List<UserKPI> KPIs { get; set; }
    }
       
    public class UserDashboard
    {
        public int Id { get; set; }       
        [Required]
        public int DashboardId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserChannel
    {
        public int Id { get; set; }        
        [Required]
        public int ChannelId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserKPI
    {
        public int Id { get; set; }       
        [Required]
        public int KPIId { get; set; }    
        public bool IsActive { get; set; }      
    }
}
