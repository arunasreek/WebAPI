using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class CyclePeriods
    {
        public List<CyclePeriodApplicationModel> Periods { get; set; }
    }

    public class CyclePeriodApplicationModel
    {
        public int Id { get; set; }
        public string Period { get; set; }
    }
}
