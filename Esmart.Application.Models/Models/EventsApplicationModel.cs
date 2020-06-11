using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class EventsApplicationModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }      
        public string EvntType { get; set; }
        public string EvntKey { get; set; }
        public string EvntName { get; set; }
        public string EvntComponents { get; set; }
        public string CustEvntStrt { get; set; }
        public string CustEvntEnd { get; set; }
        public string Notes { get; set; }
    }
}
