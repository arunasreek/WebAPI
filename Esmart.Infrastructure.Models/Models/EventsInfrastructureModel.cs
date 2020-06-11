using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class EventsInfrastructureModel
    {
        public string EvntType { get; set; }
        public string EvntKey { get; set; }
        public string EvntName { get; set; }
        public string EvntComponents { get; set; }
        public string CustEvntStrt { get; set; }
        public string CustEvntEnd { get; set; }
        public string Notes { get; set; }
        public DateTime? UploadDate { get; set; }
        public string UploadedBy { get; set; }
    }
}
