using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class AspNetUserRoleDetails
    {
        public AspNetUserRoleApplicationModel RoleDetails { get; set; }
    }

    public class AspNetUserRoleApplicationModel
    {
        [Required]
        public string UserId { get; set; }
        public int OrganisationId { get; set; }
        public List<AspNetUserRoleBasic> Roles { get; set; }
    }

    public class AspNetUserRoleBasic
    {
        [Required]
        public string RoleId { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserRolesApplicationModel
    {
        public List<UserRoleApplicationModel> RolesPrevileges { get; set; }
    }

    public class UserRoleApplicationModel
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public List<UserRolePrevilegeApplicationModel> Previleges { get; set; }
    }

    public class UserRolePrevilegeApplicationModel
    {
        public int Id { get; set; }
        public string Previlege { get; set; }
    }
}
