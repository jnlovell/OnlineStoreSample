using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class MajorAppliance : Electronic
    {
        [Display(Name = "Appliance Type")]
        public string MajorApplianceType { get; set; }
        [Display(Name = "Appliance Size")]
        public string MajorApplianceSize { get; set; }
    }
}