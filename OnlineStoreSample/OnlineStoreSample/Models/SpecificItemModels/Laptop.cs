using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Laptop : Electronic
    {
        public string StorageType { get; set; }
        public int StorageSize { get; set; }
        public int RAM { get; set; }
        public string Processor { get; set; }
        public string OperatingSystem { get; set; }
        public string ScreenSize { get; set; }
    }
}