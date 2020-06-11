using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class KPIApplicationModel
    {
        public List<KPI> Kpis { get; set; }
    }

    public class KPI
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }   
}
