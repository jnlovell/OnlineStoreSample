using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.ItemModels
{
    public class Media : Item
    {
        [Display(Name = "Specifications")]
        public string MediaDeviceSpecifications { get; set; }
        [Display(Name = "Compatible Devices")]
        public string MeidaDeviceType { get; set; }
        [Display(Name = "Disc or Digital Download")]
        public string MediaDiscOrDownLoad { get; set; }
    }
}