using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationExample.Models.View_Models.Category;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Category
{
    public class AllModel : PageModel
    {
        private ICategoryService _categoryService;

        public AllModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IList<CategoryViewModel> CategoryViewModels { get; set; }

        public async Task OnGet()
        {
            var categories = await _categoryService.GetCategoriesAsync();

            CategoryViewModels = categories.Select(category => new CategoryViewModel
            {
                Id = category.CategoryId,
                Name = category.Name,

            }).ToList();
        }
    }
}
