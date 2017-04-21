using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Movie : Media
    {
        public string MovieDiscType { get; set; }
        public string MovieRating { get; set; }
    }
}