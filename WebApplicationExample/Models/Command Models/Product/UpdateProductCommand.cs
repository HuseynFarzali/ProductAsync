using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace WebApplicationExample.Models.Command_Models.Product
{
    public class UpdateProductCommand
    {
        [Required]
        [Display(Name = "New Product Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "New Product Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "New Product Rating")]
        [Range(1, 5, ErrorMessage = "Rating of a product should be between the values 1 and 5.")]
        public int Rating { get; set; }
    }
}
