using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStoreSample.Models.ItemModels
{
    public class Electronic : Item
    {
        public string Specifications { get; set; }
        public string Warranty { get; set; }
    }
}