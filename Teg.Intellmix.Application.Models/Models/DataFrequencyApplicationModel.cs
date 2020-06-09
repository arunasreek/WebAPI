using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class DataFrequencyApplicationModel
    {
        public List<DataFrequency> DataFrequencies { get; set; }
    }

    public class DataFrequency
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
