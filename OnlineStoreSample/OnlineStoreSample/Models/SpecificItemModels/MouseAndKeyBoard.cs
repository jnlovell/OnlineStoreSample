using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class MouseAndKeyBoard : Accessory
    {
        [Display(Name = "Connection Type: USB, Cord, Wireless, etc.")]
        public string MouseAndKeyBoardConnectionType { get; set; }
        [Display(Name = "Operating System Compatibility")]
        public string MouseAndKeyBoardOsCompatibility { get; set; }
    }
}