using System.ComponentModel.DataAnnotations;

namespace BakeryMarkTest.Models
{
    public class MenuItem
    {

        [RegularExpression(@"^[0-9]{1,5}$")]
        public string MenuItemId { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "Name should be no more than 60 characters.")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Must be greater than 1 or 1")]
        public string Price { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{1,5}$")]
        public string NumberOfCalories { get; set; }
        [Required]
        [RegularExpression(@"^(Not Vegan|Vegan)$")]
        public string IsVegan { get; set; }
        [Required]
        [RegularExpression(@"^(Not Vegetarian|Vegetarian)$")]
        public string IsVegeterian { get; set; }
        
        public string ImagePath { get; set; }

        public MenuItem()
        {

        }
    }
}
