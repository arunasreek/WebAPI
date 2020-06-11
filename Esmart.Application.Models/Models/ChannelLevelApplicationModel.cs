using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class ChannelLevelApplicationModel
    {
        public List<ChannelLevel> ChannelLevels { get; set; }
    }

    public class ChannelLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
