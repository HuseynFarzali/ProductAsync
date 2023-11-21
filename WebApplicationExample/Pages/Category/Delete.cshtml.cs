using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Category
{
    public class DeleteModel : PageModel
    {
        private ICategoryService _categoryService;

        public DeleteModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToPage("All");
        }
    }
}
