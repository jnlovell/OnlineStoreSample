using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class CarryingBag : Accessory
    {
        public string Color { get; set; }
        public string BagType { get; set; }
        public string Size { get; set; }
    }
}