using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationExample.Models.View_Models.ProductItem;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.ProductItem
{
    public class AllModel : PageModel
    {
        private readonly IProductItemService _productItemService;
        private readonly IProductService _productService;
        private readonly ISizeService _sizeService;
        private readonly IColorService _colorService;
        private readonly ICategoryService _categoryService;

        public IList<ProductItemViewModel> ProductItemViewModels { get; set; }

        public AllModel(
            IProductItemService productItemService,
            IProductService productService,
            ISizeService sizeService,
            IColorService colorService,
            ICategoryService categoryService)
        {
            _productItemService = productItemService;
            _productService = productService;
            _sizeService = sizeService;
            _colorService = colorService;
            _categoryService = categoryService;

        }

        public async Task OnGet()
        {
            var productItems = await _productItemService.GetProductItemsAsync();

            ProductItemViewModels = productItems.Select(productItem => new ProductItemViewModel
            {
                ProductName = _productService.GetProductByIdAsync(productItem.ProductId).Result.Name,
                SizeName = _sizeService.GetSizeByIdAsync(productItem.SizeId).Result.Name,
                ColorName = _colorService.GetColorByIdAsync(productItem.ColorId).Result.Name,
                CategoryName = _categoryService.GetCategoryByIdAsync(productItem.CategoryId).Result.Name,
                Id = productItem.ProductItemId

            }).ToList();
        }
    }
}
