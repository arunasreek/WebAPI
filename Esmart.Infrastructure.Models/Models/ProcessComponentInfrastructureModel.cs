using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class ProcessComponentInfrastructureModel
    {
        public bool ViewLog { get; set; }
        public bool ChangeOwner { get; set; }
        public bool ChangeDueDate { get; set; }
        public bool SendNotification { get; set; }
        public bool ChangeProcessType { get; set; }
    }
}
