using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class UserDashboardDetailsInfrastructureModel
    {
        public string UserId { get; set; }
        public int OrganisationId { get; set; }
        public List<UserDashboardInfrastructureModel> UserDashboards { get; set; }
        public List<UserChannelInfrastructureModel> UserChannels { get; set; }
        public List<UserKPIInfrastructureModel> UserKPIs { get; set; }
    }

    public class UserDashboardInfrastructureModel
    {
        public int Id { get; set; }        
        public int DashboardId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserChannelInfrastructureModel
    {
        public int Id { get; set; }       
        public int ChannelId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserKPIInfrastructureModel
    {
        public int Id { get; set; }
        public int KPIId { get; set; }
        public bool IsActive { get; set; }
    }
}
