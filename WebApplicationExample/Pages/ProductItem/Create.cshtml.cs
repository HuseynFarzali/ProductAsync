using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.ProductItem;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.ProductItem
{
    public class CreateModel : PageModel
    {
        private readonly IProductItemService _productItemService;

        [BindProperty]
        public CreateProductItemCommand Command { get; set; }

        public CreateModel(IProductItemService productItemService)
        {
            _productItemService = productItemService;
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

            await _productItemService.CreateProductItemAsync(Command);
            return RedirectToPage("All");
        }
    }
}
