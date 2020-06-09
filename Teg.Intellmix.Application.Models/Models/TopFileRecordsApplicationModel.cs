using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class TopFileRecords
    {
        public TopFileRecordsApplicationModel TopFileRecordsApplicationModel{ get; set; }
    }

    public class TopFileRecordsApplicationModel
    {
        public int ErrorCount { get; set; }
        public int WarningCount { get; set; }

        public List<VolumeApplicationModel> VolumeDetails { get; set; }
        public List<SpendApplicationModel> SpendDetails { get; set; }
        public List<ShipmentsApplicationModel> ShipmentsDetails { get; set; }
        public List<EventsApplicationModel> EventsDetails { get; set; }
        public List<BrandHierarchyApplicationModel> BrandHierarchyDetails { get; set; }
        public List<FinancialsApplicationModel> FinancialsDetails { get; set; }
    }

    public class Top5RecordsApplicationModel
    {
        public int ErrorCount { get; set; }
        public int WarningCount { get; set; }
        public List<Dictionary<string, string>> Records { get; set; }
    }
}
