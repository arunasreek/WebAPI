using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Domain.Models.Models
{
    public class UserDetailsDomainModel 
    {
        public string Id { get; set; }       
        public int OrganisationId { get; set; }       
        public string FirstName { get; set; }       
        public string LastName { get; set; }               
        public string Email { get; set; }     
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public bool Status { get; set; }
        public List<UserBusinessUnitAccessDomainModel> UserBusinessUnitsAccessDomainModel { get; set; }
    }

    public class UserBusinessUnitAccessDomainModel
    {
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public bool IsActive { get; set; }
    }
}
