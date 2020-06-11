using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class EngineColumMappingDetailsInfrastructureModel
    {
        public List<EngineColumMappingInfrastructureModel> EngineColumMapping { get; set; }
    }

    public class EngineColumMappingInfrastructureModel
    {        
        public string ColumName { get; set; }
        public int UploadedFileId { get; set; }
        public List<EngineMatchedColumnNameInfrastructureModel> EngineMatchedColumnName { get; set; }
    }

    public class EngineMatchedColumnNameInfrastructureModel
    {
        public int Id { get; set; }
        public string MatchedColumnName { get; set; }
        public int ColumnOrder { get; set; }        
    }
}

