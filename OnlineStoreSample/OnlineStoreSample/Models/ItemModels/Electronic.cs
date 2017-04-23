using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.ItemModels
{
    public class Electronic : Item
    {
        [Display(Name = "Specifications")]
        public string ElectronicSpecifications { get; set; }
    }
}