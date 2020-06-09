using System;
using System.Collections.Generic;
using System.Text;

namespace Esmart.Application.Models.Models
{
    public class MediaChannelApplicationModel
    {
        public List<MediaChannel> MediaChannels { get; set; }
    }

    public class MediaChannel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
