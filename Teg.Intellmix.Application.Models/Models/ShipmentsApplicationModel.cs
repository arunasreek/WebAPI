using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class ShipmentsApplicationModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }       
        public string Brand { get; set; }
        public string Product { get; set; }
        public string Category_Code { get; set; }
        public string Channel { get; set; }
        public string Period { get; set; }
        public string ChannelVolume { get; set; }
        public string AllOutletVolume { get; set; }
        public string ProjectionFactor { get; set; }
    }
}
