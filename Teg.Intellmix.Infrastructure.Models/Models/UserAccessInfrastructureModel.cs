using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Infrastructure.Models.Models
{
    public class UserAccessInfrastructureModel
    {
        public long Id { get; set; }
        public int ProcessState { get; set; }
        public int? FileId { get; set; }
        public int PrevilegeId { get; set; }
    }
}
