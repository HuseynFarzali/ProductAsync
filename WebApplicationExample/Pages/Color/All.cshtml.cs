using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationExample.Models.View_Models.Color;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Color
{
    public class AllModel : PageModel
    {
        private IColorService _colorService;

        public AllModel(IColorService colorService)
        {
            _colorService = colorService;
        }

        public IList<ColorViewModel> ColorViewModels { get; set; }

        public async Task OnGet()
        {
            var colors = await _colorService.GetColorsAsync();

            ColorViewModels = colors.Select(color => new ColorViewModel
            {
                Id = color.ColorId,
                Name = color.Name,

            }).ToList();
        }
    }
}
