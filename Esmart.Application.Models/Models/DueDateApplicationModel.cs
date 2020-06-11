using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
   public class DueDateApplicationModel
   {
        public List<CycleDetails>  CycleDetails { get; set; }
        public Weeks Weeks { get; set; }
        public Days Days { get; set; }
        public Months Months { get; set; }
    }

    public class Selected
    {
        public bool IsSelected { get; set; }
    }

    public class CycleDetails : Selected
    {
        public int CycleId { get; set; }
        public string CycleType { get; set; }
       
    }

    public class StringEntities : Selected
    {
        public string Entity { get; set; }
    }

    public class Weeks
    {
        List<StringEntities> ListWeeks { get; set; }
    }

    public class Days
    {
        List<StringEntities> ListDays { get; set; }
    }

    public class Months
    {
        List<StringEntities> ListMonths { get; set; }
    }
}
