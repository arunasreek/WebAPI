using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class UserDashboardDetailDomainModel
    {
        public string UserId { get; set; }
        public int OrganisationId { get; set; }
        public List<UserDashboardDomainModel> Dashboards { get; set; }
        public List<UserChannelDomainModel> Channels { get; set; }
        public List<UserKPIDomainModel> KPIs { get; set; }
    }

    public class UserDashboardDomainModel
    {
        public int Id { get; set; }    
        public int DashboardId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserChannelDomainModel
    {
        public int Id { get; set; }      
        [Required]
        public int ChannelId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserKPIDomainModel
    {
        public int Id { get; set; }      
        [Required]
        public int KPIId { get; set; }
        public bool IsActive { get; set; }
    }
}
