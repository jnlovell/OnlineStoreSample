using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Movie : Media
    {
        public string DiscType { get; set; }
        public string Rating { get; set; }
    }
}