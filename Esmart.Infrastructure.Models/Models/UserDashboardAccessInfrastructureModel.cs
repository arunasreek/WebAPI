using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class UserDashboardAccessInfrastructureModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DashboardId { get; set; }
        public string DashboardName { get; set; }
    }

    public class UserDashboardURLInfrastructureModel
    {        
        public int DashboardId { get; set; }
        public string DashboardName { get; set; }
        public string DashboardURL { get; set; }
    }
}
