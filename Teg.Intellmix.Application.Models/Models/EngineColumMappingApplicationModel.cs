using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class EngineColumMapping
    {
        public EngineColumMappingDetailsApplicationModel EngineColumMappingDetails { get; set; }        
    }

    public class EngineColumMappingDetailsApplicationModel
    {
        public int UploadedFileId { get; set; }
        public List<EngineColumMappingApplicationModel> EngineColumMapping { get; set; }       
    }         

    public class EngineColumMappingApplicationModel
    {       
        public string ColumName { get; set; }       
        public List<EngineMatchedColumnNameApplicationModel> EngineMatchedColumnName { get; set; }
    }

    public class EngineMatchedColumnNameApplicationModel
    {
        public int Id { get; set; }      
        public string MatchedColumnName { get; set; }
        public int ColumnOrder { get; set; }
    }
}
