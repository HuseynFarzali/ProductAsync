using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.Size;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Size
{
    public class UpdateModel : PageModel
    {
        private ISizeService _sizeService;
        private AppDbContext _appDbContext;

        [BindProperty]
        public UpdateSizeCommand Command { get; set; }

        public UpdateModel(ISizeService sizeService, AppDbContext appDbContext)
        {
            _sizeService = sizeService;
            _appDbContext = appDbContext;
        }

        public async Task OnGet(int id)
        {
            var size = await _appDbContext.Sizes.FindAsync(id)
                ?? throw new System.Exception($"There is no size with id:{id} in the database");

            Command = new UpdateSizeCommand
            {
                Name = size.Name
            };
        }

        public async Task<IActionResult> OnPost(int id)
        {
            await _sizeService.UpdateSizeAsync(id, Command);
            return RedirectToPage("All");
        }
    }
}
