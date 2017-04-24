using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class CarryingBag : Accessory
    {
        [Display(Name = "Bag Color")]
        public string BagColor { get; set; }
        [Display(Name = "Bag Type")]
        public string BagType { get; set; }
        [Display(Name = "Bag Size")]
        public string BagSize { get; set; }
    }
}