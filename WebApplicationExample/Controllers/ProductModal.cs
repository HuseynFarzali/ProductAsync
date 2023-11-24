using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.View_Models.Category;
using WebApplicationExample.Models.View_Models.Color;
using WebApplicationExample.Models.View_Models.ProductModalViewModels;
using WebApplicationExample.Models.View_Models.Size;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Controllers
{
    [Route("/productmodal/{action}")]
    public class ProductModal : Controller
    {
        private readonly IProductService _productService;
        private readonly AppDbContext _context;

        public ProductModal(IProductService productService, AppDbContext context)
        {
            _context = context;
            _productService = productService;
        }

        [HttpGet("{id}", Name = "product-details-modal")]
        public async Task<IActionResult> GetDetailsModal(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            var usedCategoryIds = product.ProductItems.Select(pI => pI.CategoryId);
            var usedColorIds = product.ProductItems.Select(pI => pI.ColorId);
            var usedSizeIds = product.ProductItems.Select(pI => pI.SizeId);

            ProductDetailedModalViewModel ProductDetails = null;

            ProductDetails = new ProductDetailedModalViewModel
            {
                ProductId = product.ProductId,
                ProductName = product.Name,
                ProductPrice = product.Price,
                ProductRating = product.Rating,
                ProductUsedCategories = usedCategoryIds.Select(cId =>
                {
                    var foundCategory = _context.Categories.Find(cId)
                    ?? throw new System.Exception($"There is no category with id:{cId} in the database.");

                    var categoryViewModel = new CategoryViewModel
                    {
                        Id = foundCategory.CategoryId,
                        Name = foundCategory.Name,
                    };

                    return categoryViewModel;
                }).ToList(),

                ProductUsedColors = usedColorIds.Select(cId =>
                {
                    var foundColor = _context.Colors.Find(cId)
                    ?? throw new System.Exception($"There is no colors with id:{cId} in the database.");

                    var colorViewModel = new ColorViewModel
                    {
                        Id = foundColor.ColorId,
                        Name = foundColor.Name,
                    };

                    return colorViewModel;
                }).ToList(),

                ProductUsedSizes = usedSizeIds.Select(sId =>
                {
                    var foundSize = _context.Sizes.Find(sId)
                    ?? throw new System.Exception($"There is no category with id:{sId} in the database.");

                    var sizeViewModel = new SizeViewModel
                    {
                        Id = foundSize.SizeId,
                        Name = foundSize.Name,
                    };

                    return sizeViewModel;
                }).ToList()
            };

            return View("Views/Partials/ProductModal/_ProductDetailsModalPartial.cshtml", ProductDetails);
        }
    }
}
