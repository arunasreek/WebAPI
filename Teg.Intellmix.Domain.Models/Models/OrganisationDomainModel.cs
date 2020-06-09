using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class OrganisationDomainBasicModel
    {
        public int Id { get; set; }
        public string OrgName { get; set; }
        public int StatusId { get; set; }
        public string OrgEmailFormat { get; set; }
        public string OrgLogoUrl { get; set; }
        public int SubscriptionId { get; set; }
        public int CycleId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }  
    
    public class OrganisationDomainModel
    {
        public int Id { get; set; }
        public string OrgName { get; set; }
        public int StatusId { get; set; }
        public string OrgEmailFormat { get; set; }
        public string OrgLogoUrl { get; set; }
        public List<OrganisationSubscriptionDomainModel> OrganisationSubscription { get; set; }
        public List<OrganisationCycleDomainModel> OrganisationCycle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }      
    }

    public class OrganisationSubscriptionDomainModel
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

    public class OrganisationCycleDomainModel
    {
        public int OrganisationId { get; set; }
        public int CycleId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }


    public class OrganisationAdminModel
    {
        public string Id { get; set; }
    }

    public class OrganisationAdminDomainModel
    {
        public int OrganisationId { get; set; }
        public List<OrganisationAdminModel> organisationAdminModels { get; set; }
    }
}
