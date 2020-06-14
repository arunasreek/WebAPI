using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class EnterpriseListInfrastructureModel
    {
       
    }

    public class EnterpriseList
    {
        public Int64 ep_id { get; set; }
        public string EnterpriseID { get; set; }
        public string EnterpriseName { get; set; }
        public string ParentEnterprise { get; set; }
        public string PermanentRegistration { get; set; }
        public DateTime DateOfInception { get; set; }
        public DateTime DateOfExpiry { get; set; }
    }
}
