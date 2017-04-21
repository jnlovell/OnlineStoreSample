using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class GameConsole : Electronic
    {
        public string Color { get; set; }
        public int Storage { get; set; }
    }
}