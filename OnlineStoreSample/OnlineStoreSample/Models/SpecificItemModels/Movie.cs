using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Movie : Media
    {
        [Display(Name = "Disc Type: DVD, BLueRay, Digital")]
        public string MovieDiscType { get; set; }
        [Display(Name = "Rating")]
        public string MovieRating { get; set; }
    }
}