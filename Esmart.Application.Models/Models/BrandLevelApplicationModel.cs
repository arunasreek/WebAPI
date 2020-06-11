using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class BrandLevelApplicationModel
    {
        public List<BrandLevel> BrandLevels { get; set; }
    }

    public class BrandLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
