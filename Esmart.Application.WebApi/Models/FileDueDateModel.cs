using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esmart.Application.WebApi.Models
{
    public class FileDueDateModel
    {
        public string WeekOfTheMonth { get; set; }
        public string DayOfTheWeek { get; set; }
        public string MonthOfTheCycle { get; set; }
    }
}