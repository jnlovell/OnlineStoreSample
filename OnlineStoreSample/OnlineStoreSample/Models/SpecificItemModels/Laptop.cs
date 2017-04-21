using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Laptop : Electronic
    {
        public string LaptopStorageType { get; set; }
        public int LaptopStorageSize { get; set; }
        public int LaptopRAM { get; set; }
        public string LaptopProcessor { get; set; }
        public string LaptopOperatingSystem { get; set; }
        public string LaptopScreenSize { get; set; }
    }
}