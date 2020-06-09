using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class ShipmentsInfrastructureModel
    {
        public string Brand { get; set; }
        public string Product { get; set; }
        public string Category_Code { get; set; }
        public string Channel { get; set; }
        public string Period { get; set; }
        public string ChannelVolume { get; set; }
        public string AllOutletVolume { get; set; }
        public string ProjectionFactor { get; set; }
        public DateTime? UploadDate { get; set; }
        public string UploadedBy { get; set; }
    }
}
