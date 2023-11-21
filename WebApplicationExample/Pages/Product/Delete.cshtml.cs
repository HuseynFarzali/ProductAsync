using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Services.Implementations;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Product
{
    public class DeleteModel : PageModel
    {
        private IProductService _productService;

        public DeleteModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> OnGet([FromRoute] int id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToPage("All");
        }
    }
}
