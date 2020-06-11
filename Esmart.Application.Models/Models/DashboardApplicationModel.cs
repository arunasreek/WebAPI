using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class DashboardApplicationModel
    {
        public List<Dashboard> Dashboards { get; set; }
    }

    public class Dashboard
    {
        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
    }
}
