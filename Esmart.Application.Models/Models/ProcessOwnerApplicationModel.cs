using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class ProcessOwnerResultModel
    {
        public List<ProcessOwnerApplicationModel> ProcessOwners { get; set; }
    }

    public class ProcessOwnerApplicationModel
    {
        public string Id { get; set; }
        public string OwnerName { get; set; }
        public bool IsSelected { get; set; }
    }

}
