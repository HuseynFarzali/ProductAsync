using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.Size;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Size
{
    public class CreateModel : PageModel
    {
        private ISizeService _sizeService;

        [BindProperty]
        public CreateSizeCommand Command { get; set; }

        public CreateModel(ISizeService sizeService)
        {
            _sizeService = sizeService;
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

            await _sizeService.CreateSizeAsync(Command);
            return RedirectToPage("All");
        }
    }
}
