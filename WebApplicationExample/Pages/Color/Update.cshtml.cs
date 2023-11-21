using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.Color;
using WebApplicationExample.Services.Implementations;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Color
{
    public class UpdateModel : PageModel
    {
        private IColorService _colorService;
        private AppDbContext _appDbContext;

        [BindProperty]
        public UpdateColorCommand Command { get; set; }

        public UpdateModel(IColorService colorService, AppDbContext appDbContext)
        {
            _colorService = colorService;
            _appDbContext = appDbContext;
        }

        public async Task OnGet(int id)
        {
            var color = await _appDbContext.Colors.FindAsync(id)
                ?? throw new Exception($"There is no size with id:{id} in the database.");

            Command = new UpdateColorCommand
            {
                Name = color.Name,
            };
        }

        public async Task<IActionResult> OnPost(int id)
        {
            await _colorService.UpdateColorAsync(id, Command);
            return RedirectToPage("All");
        }
    }
}
