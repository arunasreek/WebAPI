using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class SendNotificationDomainModel
    {
        public int OrganisationId { get; set; }
        public int BusinessUnitId { get; set; }
        public int FileTypeId { get; set; }
        public int PeriodId { get; set; }
        public int ProcessStateId { get; set; }
        public string NotificationRemarks { get; set; }
    }
}
