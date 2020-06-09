using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class UserInfrastructureModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public bool IsInOrgRole { get; set; }
        public List<RolesInfrastructureModel> Roles { get; set; }
    }

    public class UserStatusChangeInfrastructureModel
    {
        public int OrgId { get; set; }
        public string UserId { get; set; }
        public int Status { get; set; }
    }

    public class UserProfileInfrastructureModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<RolesModel> Roles { get; set; }
        public List<PrivilegesModel> Privileges { get; set; }
        public ProcessActions processActions { get; set; }
    }

    public class RolesModel
    {
        public string Id { get; set; }
        public string Role { get; set; }

    }

    public class PrivilegesModel
    {
        public string Privilege { get; set; }
    }


    public class ProcessActions
    {
        public List<DataTypeActions>  dataTypeActions { get; set; }
    }

    public class DataTypeActions
    {
        public string DataType { get; set; }
        public string Actions { get; set; }
        public string BusinessUnit { get; set; }
    }
}
