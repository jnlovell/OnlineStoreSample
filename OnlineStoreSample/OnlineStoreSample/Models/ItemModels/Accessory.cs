using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStoreSample.Models.ItemModels
{
    public class Accessory : Item
    {
        public string Description { get; set; }
        public string Warranty { get; set; }
    }
}