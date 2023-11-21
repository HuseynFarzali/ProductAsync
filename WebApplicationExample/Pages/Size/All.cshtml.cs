using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WebApplicationExample.Models.View_Models.Size;
using WebApplicationExample.Services.Implementations;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Size
{
    public class AllModel : PageModel
    {
        private ISizeService _sizeService;

        public AllModel(ISizeService sizeService)
        {
            _sizeService = sizeService;
        }

        public IList<SizeViewModel> SizeViewModels { get; set; }

        public async Task OnGet()
        {
            var sizes = await _sizeService.GetSizesAsync();

            SizeViewModels = sizes.Select(size => new SizeViewModel
            {
                Id = size.SizeId,
                Name = size.Name

            }).ToList();
        }
    }
}
