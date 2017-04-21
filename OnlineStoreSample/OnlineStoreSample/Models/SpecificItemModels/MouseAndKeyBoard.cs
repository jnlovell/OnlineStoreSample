using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class MouseAndKeyBoard : Accessory
    {
        public string ConnectionType { get; set; }
        public string OsCompatibility { get; set; }
    }
}