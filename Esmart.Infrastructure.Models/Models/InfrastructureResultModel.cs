using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class InfrastructureResultModel
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public object Result { get; set; }
    }
}
