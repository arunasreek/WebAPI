using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class ProcessOwnerInfrastructureModel
    {
        public string Id { get; set; }
        public string OwnerName { get; set; }
        public bool IsSelected { get; set; }
    }

    public class ProcessOwnerDetailsInfrastructureModel
    {
        public string Id { get; set; }
        public string OwnerName { get; set; }
        public string Email { get; set; }
        public int FileTypeId { get; set; }
    }
}
