using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class CycleApplicationModel
    {
        public List<Cycles> Cycles { get; set; }
    }

    public class Cycles
    {
        public int Id { get; set; }
        public string Cycle { get; set; }
    }
}
