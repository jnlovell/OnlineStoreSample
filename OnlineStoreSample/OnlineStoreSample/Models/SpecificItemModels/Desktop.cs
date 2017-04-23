using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Desktop : Electronic
    {
        [Required]
        [Display(Name = "Storage Type")]
        public string DesktopStorageType { get; set; }
        [Required]
        [Display(Name = "Storage Size: GB")]
        public int DesktopStorageSize { get; set; }
        [Required]
        [Display(Name = "Memory")]
        public int DesktopRAM { get; set; }
        [Required]
        [Display(Name = "Processor")]
        public string DesktopProcessor { get; set; }
        [Required]
        [Display(Name = "Operating System")]
        public string DesktopOperatingSystem { get; set; }
    }
}