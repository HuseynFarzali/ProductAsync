using System.ComponentModel.DataAnnotations;
using WebApplicationExample.Attributes.Validation_Attributes;

namespace WebApplicationExample.Models.Command_Models.ProductItem
{
    public class CreateProductItemCommand
    {
        [ValidEntityId(typeof(Domain_Models.Product))]
        [Required]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [ValidEntityId(typeof(Domain_Models.Size))]
        [Required]
        [Display(Name = "Size ID")]
        public int SizeId { get; set; }

        [ValidEntityId(typeof(Domain_Models.Color))]
        [Required]
        [Display(Name = "Color ID")]
        public int ColorId { get; set; }

        [ValidEntityId(typeof(Domain_Models.Category))]
        [Required]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }
    }
}
