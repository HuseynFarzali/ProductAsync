using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Services.Implementations;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Size
{
    public class DeleteModel : PageModel
    {
        private ISizeService _sizeService;

        public DeleteModel(ISizeService sizeService)
        {
            _sizeService = sizeService;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            await _sizeService.DeleteSizeAsync(id);
            return RedirectToPage("All");
        }
    }
}
