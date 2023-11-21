using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationExample.Models.View_Models;
using WebApplicationExample.Models.View_Models.Product;
using WebApplicationExample.Services.Implementations;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Product
{
    public class AllModel : PageModel
    {
        private IProductService _productService;

        public IList<ProductViewModel> ProductViewModels { get; set; }

        public AllModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task OnGet()
        {
            var products = await _productService.GetProductsAsync();

            ProductViewModels = products.Select(product => new ProductViewModel
            {
                Id = product.ProductId,
                Name = product.Name,
                Rating = product.Rating,
                Price = product.Price

            }).ToList();
        }
    }
}
