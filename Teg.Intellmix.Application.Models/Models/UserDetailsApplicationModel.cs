using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class UserDetailApplicationModel
    {
        public UserDetailsApplicationModel UserBasicDetails { get; set; }
    }

    public class UserDetailsApplicationModel
    {
        public string Id { get; set; }
        [Required]
        public int OrganisationId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool Status { get; set; }      
        [Required]
        public List<UserBusinessUnitAccess> UserBusinessUnitAccess { get; set; }
    }

    public class UserBusinessUnitAccess
    {
        //public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserDetailsApplicationResultModel
    {
        public string UserId { get; set; }
    }

    public class UserPublishDetails
    {
        public UserPublishStatusApplicationModel userPublishStatus { get; set; }
    }

    public class UserPublishStatusApplicationModel
    {
        public string UserId { get; set; }
        public bool IsPublished { get; set; }
        public bool IsRoleAssigned { get; set; }
        public bool IsDashboardAssigned { get; set; }
    }

    public class UserDetailsBUAccessApplicationModel
    {
        public int BUId { get; set; }
        public int OrganisationId { get; set; }
        public string UserId { get; set; }
    }

    public class UserDetailsBUFileAccessApplicationModel
    {
        public int BusinessUnitId { get; set; }
        public int OrganisationId { get; set; }
        public string UserId { get; set; }
        public int FileId { get; set; }
        public int ProcessStateId { get; set; }
        public int PreviligeId { get; set; }
    }
}
