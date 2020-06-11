using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
   public class FinancialsInfrastructureModel
    {
        public string Product { get; set; }
        public string Category_Code { get; set; }
        public string Retail_Price { get; set; }
        public string Channel_Selling_Price { get; set; }
        public string Expected_Contribution { get; set; }
        public string Adjusted_Contribution { get; set; }
        public DateTime UploadDate { get; set; }
        public string UploadedBy { get; set; }
    }
}
