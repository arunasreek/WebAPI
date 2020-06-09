using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class OrganisationDetailInfrastructureModel
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

    public class OrganisationAdminModel
    {
        public string Id { get; set; }
    }

    public class OrganisationAdminInfrastructureModel
    {
        public int OrganisationId { get; set; }
        public List<OrganisationAdminModel> organisationAdminModels { get; set; }
    }
}
