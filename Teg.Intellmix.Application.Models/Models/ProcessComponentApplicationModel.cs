using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
   public class ProcessComponentApplicationModel
    {
        public bool ViewLog { get; set; }
        public bool ChangeOwner { get; set; }
        public bool ChangeDueDate { get; set; }
        public bool SendNotification { get; set; }
        public bool ChangeProcessType { get; set; }
    }
}
