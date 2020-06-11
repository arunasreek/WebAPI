using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class VolumeApplicationModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }       
        public string Outlet { get; set; }
        public string Category_Code { get; set; }
        public string Product_Key { get; set; }
        public string geogkey { get; set; }
        public string week { get; set; }
        public string SalesComponent { get; set; }
        public string Dueto_value { get; set; }
        public string PrimaryCausalKey { get; set; }
        public string causal_value { get; set; }     
    }
}
