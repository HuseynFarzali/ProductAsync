using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.Product;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Product
{
    public class UpdateModel : PageModel
    {
        private IProductService _productService;
        private AppDbContext _appDbContext;

        [BindProperty]
        public UpdateProductCommand UpdateCommand { get; set; }

        public UpdateModel(IProductService productService, AppDbContext appDbContext)
        {
            _productService = productService;
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> OnGet(int id)
        {
            var product = await _appDbContext.Products.FindAsync(id)
                ?? throw new System.Exception($"There is no product with id:{id} in the database.");

            UpdateCommand = new UpdateProductCommand
            {
                Name = product.Name,
                Rating = product.Rating,
                Price = product.Price
            };

            return Page();
        }

        public async Task<IActionResult> OnPost([FromRoute] int id)
        {
            await _productService.UpdateProductAsync(id, UpdateCommand);
            return RedirectToPage("All");
        }
    }
}
