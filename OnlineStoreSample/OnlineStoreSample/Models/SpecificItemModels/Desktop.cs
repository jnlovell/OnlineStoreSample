using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Desktop : Electronic
    {
        public string DesktopStorageType { get; set; }
        public int DesktopStorageSize { get; set; }
        public int DesktopRAM { get; set; }
        public string DesktopProcessor { get; set; }
        public string DesktopOperatingSystem { get; set; }
    }
}