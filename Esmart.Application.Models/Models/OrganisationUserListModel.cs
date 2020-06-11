using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class OrganisationUserListModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }

    public class OrganisationAdminModel
    {
        public string Id { get; set; }
    }

    public class OrganisationAdminApplicationModel
    {
        public int OrganisationId { get; set; }
        public List<OrganisationAdminModel> organisationAdminModels { get; set; }
    }
}
