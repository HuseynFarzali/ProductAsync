using Microsoft.AspNetCore.Cors;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplicationExample.Models.View_Models.Category;
using WebApplicationExample.Models.View_Models.Color;
using WebApplicationExample.Models.View_Models.Size;

namespace WebApplicationExample.Models.View_Models.ProductModalViewModels
{
    public class ProductDetailedModalViewModel
    {
        [Display(Name = "Product ID: ")]
        public int ProductId { get; set; }

        [Display(Name = "Rating: ")]
        public int ProductRating { get; set; }

        [Display(Name = "Price: ")]
        public decimal ProductPrice { get; set; }

        [Display(Name = "Name: ")]
        public string ProductName { get; set; }

        [Display(Name = "Used Colors: ")]
        public IList<ColorViewModel> ProductUsedColors { get; set; }

        [Display(Name = "Used Sizes: ")]
        public IList<SizeViewModel> ProductUsedSizes { get; set; }

        [Display(Name = "Used Categories: ")]
        public IList<CategoryViewModel> ProductUsedCategories { get; set; }
    }
}
