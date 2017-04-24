using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Software : Media
    {
        [Display(Name = "Size in MB")]
        public int SoftwareSize { get; set; }
        [Display(Name = "Operating System Compatibility")]
        public string SoftwareOperatingSystems { get; set; }

    }
}