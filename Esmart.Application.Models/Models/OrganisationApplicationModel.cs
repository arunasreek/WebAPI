using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class OrganisationBasicDetails
    {
        public int Id { get; set; }
        public string OrgName { get; set; }
        public int StatusId { get; set; }
        public string OrgEmailFormat { get; set; }
        public string OrgLogoUrl { get; set; }
        public int SubscriptionId { get; set; }
        public int CycleId { get; set; }       
    }

    public class OrganisationApplicationModel
    {
        public int Id { get; set; }
        public string OrgName { get; set; }
        public int StatusId { get; set; }
        public string OrgEmailFormat { get; set; }
        public string OrgLogoUrl { get; set; }
        public List<OrganisationSubscriptionApplicationModel> OrganisationSubscription { get; set; }
        public List<OrganisationCycleApplicationModel> OrganisationCycle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public class OrganisationSubscriptionApplicationModel
    {
        public int OrganisationId { get; set; }
        public int SubscriptionId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public class OrganisationCycleApplicationModel
    {
        public int OrganisationId { get; set; }
        public int CycleId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
