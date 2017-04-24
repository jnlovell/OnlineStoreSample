using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class VideoGame : Media
    {
        [Display(Name = "Game Rating")]
        public string VideoGameRating { get; set; }
        [Display(Name = "Console Compatibility")]
        public string VideoGameConsoleName { get; set; }
    }
}