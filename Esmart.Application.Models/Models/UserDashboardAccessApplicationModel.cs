using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class UserDashboardAccessApplicationModel
    {
        public List<UserDashboardAccess> UserDashboardAccess { get; set; }
    }

    public class UserDashboardAccess
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DashboardId { get; set; }
        public string DashboardName { get; set; }
    }

    public class UserDashboardURLApplicationModel
    {
        public UserDashboardURL UserDashboardURL { get; set; }
    }

    public class UserDashboardURL
    {        
        public int DashboardId { get; set; }
        public string DashboardName { get; set; }
        public string DashboardURL { get; set; }
    }
}
