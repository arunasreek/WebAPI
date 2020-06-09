using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class OrganisationDetailApplicationModel
    {
        public  List<Organisation> Organisation { get; set; }
    }

    public class Organisation
    {
        public int OrgId { get; set; }
        public string OrgName { get; set; }
        public string OrgEmailFormat { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public DateTime ActiveFromdate { get; set; }
        public int SubscriptionPeriodId { get; set; }
        public int DataCycleId { get; set; }
        public string OrgLogo { get; set; }
        
    }
}
