using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class VideoGame : Media
    {
        public string GameRating { get; set; }
        public string ConsoleName { get; set; }
    }
}