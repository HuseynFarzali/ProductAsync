using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.ProductItem;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.ProductItem
{
    public class UpdateModel : PageModel
    {
        private IProductItemService _productItemService;
        private AppDbContext _appDbContext;

        [BindProperty]
        public UpdateProductItemCommand Command { get; set; }

        public UpdateModel(IProductItemService productItemService, AppDbContext appDbContext)
        {
            _productItemService = productItemService;
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            var productItem = await _appDbContext.ProductItems.FindAsync(id)
                ?? throw new System.Exception($"There is no product-item with id:{id} in the database.");

            Command = new UpdateProductItemCommand
            {
                ColorId = productItem.ColorId,
                SizeId = productItem.SizeId,
                ProductId = productItem.ProductId,
            };

            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            await _productItemService.UpdateProductItemAsync(id, Command);
            return RedirectToPage("All");
        }
    }
}
