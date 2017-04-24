using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class GameConsole : Electronic
    {
        [Display(Name = "Color")]
        public string GameConsoleColor { get; set; }
        [Display(Name = "Storage Size: GB")]
        public int GameConsoleStorage { get; set; }
    }
}