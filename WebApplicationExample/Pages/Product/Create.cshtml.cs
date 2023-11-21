using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.Product;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Product
{
    public class CreateModel : PageModel
    {
        private IProductService _productService;

        [BindProperty]
        public CreateProductCommand Command { get; set; }

        public CreateModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _productService.CreateProductAsync(Command);
            return RedirectToPage("All");
        }
    }
}
