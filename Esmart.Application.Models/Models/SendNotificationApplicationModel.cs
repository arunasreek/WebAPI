using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class SendNotificationApplicationModel
    {
        public int OrganisationId { get; set; }
        public int BusinessUnitId { get; set; }
        public int FileTypeId { get; set; }
        public int PeriodId { get; set; }
        public int ProcessStateId { get; set; }
        public string NotificationRemarks { get; set; }
    }
}
