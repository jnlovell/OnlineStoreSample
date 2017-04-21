using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Software : Media
    {
        public int Size { get; set; }
        public string OperatingSystems { get; set; }

    }
}