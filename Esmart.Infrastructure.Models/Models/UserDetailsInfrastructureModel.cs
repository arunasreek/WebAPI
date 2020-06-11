using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class UserDetailsInfrastructureModel
    {
        public string Id { get; set; }
        public int OrganisationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool Status { get; set; }
        public List<UserBusinessUnitAccessInfrastructureModel> UserBusinessUnitsAccessInfrastructureModel { get; set; }
    }

    public class UserBusinessUnitAccessInfrastructureModel
    {
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserPublishStatusInfrastructureModel
    {
        public string UserId { get; set; }
        public bool IsPublished { get; set; }
        public bool IsRoleAssigned { get; set; }
        public bool IsDashboardAssigned { get; set; }
    }
}
