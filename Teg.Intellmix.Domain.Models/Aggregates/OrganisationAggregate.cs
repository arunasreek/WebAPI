using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Aggregates
{
    public class FileTypeAggregate
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class OrganisationAggregate
    {
        public int Id { get; set; }
        public string OrgName { get; set; }
        public int StatusId { get; set; }
        public string OrgEmailFormat { get; set; }
        public string OrgLogoUrl { get; set; }
        public List<OrganisationSubscriptionAggregate> OrganisationSubscription { get; set; }
        public List<OrganisationCycleAggregate> OrganisationCycle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }

    public class OrganisationSubscriptionAggregate
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

    public class OrganisationCycleAggregate
    {
        public int OrganisationId { get; set; }
        public int CycleId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
		public List<OrganisationCycleDetailsAggregate> OrganisationCycleDetails { get; set; }
    }

	public class OrganisationCycleDetailsAggregate
	{
		public int OrganisationCycleId { get; set; }
		public string CyclePeriod { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}


    public class OrganisationAdminAggregate
    {
        public string Id { get; set; }
    }

    public class OrganisationAdminListAggregate
    {
        public int OrganisationId { get; set; }
        public List<OrganisationAdminAggregate> OrganisationAdminAggregates { get; set; }
    }
}
