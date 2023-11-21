using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.ProductItem
{
    public class DeleteModel : PageModel
    {
        private readonly IProductItemService _productItemService;

        public DeleteModel(IProductItemService productService)
        {
            _productItemService = productService;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            await _productItemService.DeleteProductItemAsync(id);
            return RedirectToPage("All");
        }
    }
}
