using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class UserColumMappingInfrastructureModel
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public string MatchedColumnName { get; set; }
        public int UploadedFileId { get; set; }
    }
}
