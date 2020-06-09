using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
   public class PagingParameterApplicationModel
    {
        public int pageNumber { get; set; } = 1;

        public int pageSize { get; set; } = 10;

        public string QuerySearch { get; set; }

        public int RoleId { get; set; } = 0;

        public int StatusId { get; set; } = 0;
    }
}
