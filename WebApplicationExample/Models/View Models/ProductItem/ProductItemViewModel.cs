using System.ComponentModel.DataAnnotations;

namespace WebApplicationExample.Models.View_Models.ProductItem
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Size")]
        public string SizeName { get; set; }

        [Display(Name = "Product Color")]
        public string ColorName { get; set; }

        [Display(Name = "Product Category")]
        public string CategoryName { get; set; }
    }
}
