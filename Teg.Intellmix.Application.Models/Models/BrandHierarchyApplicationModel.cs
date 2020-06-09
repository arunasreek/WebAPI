using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class BrandHierarchyApplicationModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }      
        public string Country { get; set; }
        public string Division { get; set; }
        public string BU { get; set; }
        public string Studio { get; set; }
        public string Neighborhoods { get; set; }
        public string Brand { get; set; }
        public string Product { get; set; }
        public string Category_Code { get; set; }
        public string Product_Key { get; set; }
    }
}
