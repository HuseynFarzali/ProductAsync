using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Color
{
    public class DeleteModel : PageModel
    {
        private IColorService _colorService;

        public DeleteModel(IColorService colorService)
        {
            _colorService = colorService;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            await _colorService.DeleteColorAsync(id);
            return RedirectToPage("All");
        }
    }
}
