using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStoreSample.Models.ItemModels
{
    public class Media : Item
    {
        public string DeviceSpecifications { get; set; }
        public string DeviceType { get; set; }
        public string Warranty { get; set; }
        public string DiscOrDownLoad { get; set; }
    }
}