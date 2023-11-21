using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationExample.Models.Command_Models.Product
{
    public partial class CreateProductCommand
    {
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Product Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Product Rating")]
        [Range(1, 5, ErrorMessage = "Rating of a product should be between the values 1 and 5")]
        public int Rating { get; set; }
    }
}
