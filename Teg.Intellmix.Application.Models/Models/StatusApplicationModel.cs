using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class StatusApplicationModel
    {
        public List<Status> Status { get; set; }
        
    }

    public class Status
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
    }
}
