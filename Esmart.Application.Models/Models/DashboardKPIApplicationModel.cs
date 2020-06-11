using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class DashboardKPIApplicationModel
    {
        public DashboardKPI DashboardKPIs { get; set; }
    }

    public class DashboardKPI
    {
        public int Organisation { get; set; }
        public int User { get; set; }
        public int DataSet { get; set; }
        public int BusinessUnit { get; set; }
    }
}
