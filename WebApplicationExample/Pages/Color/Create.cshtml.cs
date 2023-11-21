using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.Color;
using WebApplicationExample.Services.Implementations;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Color
{
    public class CreateModel : PageModel
    {
        private IColorService _colorService;

        [BindProperty]
        public CreateColorCommand Command { get; set; }

        public CreateModel(IColorService colorService)
        {
            _colorService = colorService;
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

            await _colorService.CreateColorAsync(Command);
            return RedirectToPage("All");
        }
    }
}
