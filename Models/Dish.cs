using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsAndDishes.Models
{
    public class Dish
    {
        [Key]
        public int  DishID { get; set; }
        public int ChefID { get; set; }

        [Display(Name = "Dish Name")]
        [Required]
        [MinLength(2, ErrorMessage = "Dish name must be 2 characters or more!")]
        public string DishName { get; set; }

        [Display(Name = "Tastiness")]
        [Required(ErrorMessage = "Tastiness is required!")]
        [Range(1,5)]
        public int Tastiness { get; set; }

        [Display(Name = "Calories")]
        [Required(ErrorMessage = "Calories is required!")]
        public int Calories { get; set; }

        [Display(Name = "Description")]
        [Required]
        [MinLength(10, ErrorMessage = "Description must be 10 characters or more")]
        public string Description { get; set; }

        public Chef Creator { get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}