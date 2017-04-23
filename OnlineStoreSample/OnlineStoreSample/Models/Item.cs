using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [Range(1, 2000000)]
        public int SKU { get; set; }
        [Required]
        [Display(Name = "Price U.S. Dollars")]
        [Range(1, 20000)]
        public double Price { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Warranty { get; set; }
    }
}