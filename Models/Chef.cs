using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsAndDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [MinLength(2, ErrorMessage = "First name must be 2 characters or more!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MinLength(2, ErrorMessage = "Last name must be 2 characters or more!")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Updated At")]
        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; }

        public List<Dish> CreatedDishes { get; set; }
    }
}