using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class BrandHierarchyInfrastructureModel
    {
        public string Country { get; set; }
        public string Division { get; set; }
        public string BU { get; set; }
        public string Studio { get; set; }
        public string Neighborhoods { get; set; }
        public string Brand { get; set; }
        public string Product { get; set; }
        public string Category_Code { get; set; }
        public string Product_Key { get; set; }
        public DateTime? UploadDate { get; set; }
        public string UploadedBy { get; set; }
    }
}
