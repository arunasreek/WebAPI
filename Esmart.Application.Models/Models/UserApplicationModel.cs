using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class UserApplicationModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public List<RolesApplicationModel> Roles { get; set; }
    }

    public class UserStatusChangeApplicationModel
    {
        public int organisationId { get; set; }
        public string UserId { get; set; }
        public int StatusId { get; set; }
    }

    public class UserProfileApplicationModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<RoleModel> Roles { get; set; }
        public List<PrivilegeModel> Privileges { get; set; }
        public ProcessActions processActions { get; set; }
    }

    public class RoleModel
    {
        public string Id { get; set; }
        public string Role { get; set; }
    }

    public class PrivilegeModel
    {
        public string Privilege { get; set; }
    }

    public class ProcessActions
    {
        public List<DataTypeActions> dataTypeActions { get; set; }
    }

    public class DataTypeActions
    {
        public string DataType { get; set; }
        public string Actions { get; set; }
    }
}
