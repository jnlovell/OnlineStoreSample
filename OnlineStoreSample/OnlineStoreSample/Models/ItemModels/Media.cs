using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStoreSample.Models.ItemModels
{
    public class Media : Item
    {
        public string MediaDeviceSpecifications { get; set; }
        public string MeidaDeviceType { get; set; }
        public string MediaDiscOrDownLoad { get; set; }
    }
}