using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class MajorAppliance : Electronic
    {
        public string ApplianceType { get; set; }
        public string Size { get; set; }
    }
}