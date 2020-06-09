using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class VolumeInfrastructureModel
    {
        public string Outlet { get; set; }
        public string Category_Code { get; set; }
        public string Product_Key { get; set; }
        public string geogkey { get; set; }
        public string week { get; set; }
        public string SalesComponent { get; set; }
        public string Dueto_value { get; set; }
        public string PrimaryCausalKey { get; set; }
        public string causal_value { get; set; }
        public DateTime? UploadDate { get; set; }
        public string UploadedBy { get; set; }
        
    }
}
