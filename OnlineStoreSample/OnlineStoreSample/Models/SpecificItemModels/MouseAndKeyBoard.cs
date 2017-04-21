using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class MouseAndKeyBoard : Accessory
    {
        public string MouseAndKeyBoardConnectionType { get; set; }
        public string MouseAndKeyBoardOsCompatibility { get; set; }
    }
}