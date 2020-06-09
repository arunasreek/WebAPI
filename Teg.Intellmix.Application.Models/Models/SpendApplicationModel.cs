using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class SpendApplicationModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }      
        public string FiscalYear { get; set; }
        public string FiscalQuarter { get; set; }
        public string Brand { get; set; }
        public string Market { get; set; }
        public string ConsumerBehavior { get; set; }
        public string Channel { get; set; }
        public string SubChannel { get; set; }
        public string Campaign { get; set; }
        public string EventName { get; set; }
        public string EventKey { get; set; }
        public string ReportedSpend { get; set; }
        public string ModeledSpend { get; set; }      
    }
}
