using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Laptop : Electronic
    {
        [Display(Name = "Storage Type: SSD or Hard Drive")]
        public string LaptopStorageType { get; set; }
        [Display(Name = "Storage Size: GB")]
        public int LaptopStorageSize { get; set; }
        [Display(Name = "Memory Size: GB")]
        public int LaptopRAM { get; set; }
        [Display(Name = "Processor")]
        public string LaptopProcessor { get; set; }
        [Display(Name = "Operating System")]
        public string LaptopOperatingSystem { get; set; }
        [Display(Name = "Screen Size: Inches")]
        public string LaptopScreenSize { get; set; }
    }
}