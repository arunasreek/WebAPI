using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class ETLFinalInfrastructureModel
    {
        //public Guid ETLFileGroupId { get; set; } 
        public string Level { get; set; }
        public string Country { get; set; }
        public string PeriodType { get; set; }
        public string Report_Period { get; set; }
        public string Actual_Period { get; set; }
        public string Source_BDA { get; set; }
        public string Brand { get; set; }
        public string Studio { get; set; }
        public string Neighborhoods { get; set; }
        public string BU { get; set; }
        public string Division { get; set; }
        public string SubChannel { get; set; }
        public string MediaChannel { get; set; }
        public string Market { get; set; }
        public string ConsumerBehavior { get; set; }
        public string EventName { get; set; }
        public string Published { get; set; }
        public double? Spend { get; set; }
        public double? GRPs { get; set; }
        public string Product { get; set; }
        public string Category_Code { get; set; }
        public double? DuetoVolume { get; set; }
        public double? ReportedSpend { get; set; }
        public double? ModeledSpend { get; set; }
        public string Channel { get; set; }
        public double? ChannelVolume { get; set; }
        public double? AllOutletVolume { get; set; }
        public double? ProjectionFactor { get; set; }
        public double? Retail_Price { get; set; }
        public double? Channel_Selling_Price { get; set; }
        public double? Expected_Contribution { get; set; }
        public double? Adjusted_Contribution { get; set; }
        public double? Volume { get; set; }
        public double? AC { get; set; }
        public bool IsValid { get; set; }
    }
}
