using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.Category;
using WebApplicationExample.Models.Command_Models.Color;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Pages.Category
{
    public class CreateModel : PageModel
    {
        private ICategoryService _categoryService;

        [BindProperty]
        public CreateCategoryCommand Command { get; set; }

        public CreateModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
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

            await _categoryService.CreateCategoryAsync(Command);
            return RedirectToPage("All");
        }
    }
}
