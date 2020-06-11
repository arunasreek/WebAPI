using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class FinancialsApplicationModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public string Product { get; set; }
        public string Category_Code { get; set; }
        public string Retail_Price { get; set; }
        public string Channel_Selling_Price { get; set; }
        public string Expected_Contribution { get; set; }
        public string Adjusted_Contribution { get; set; }
    }
}
