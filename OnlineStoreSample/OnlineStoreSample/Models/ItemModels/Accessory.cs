using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.ItemModels
{
    public class Accessory : Item
    {
        [Display(Name = "Accessory Description")]
        public string AccessoryDescription { get; set; }
    }
}