using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.Color;
using WebApplicationExample.Services.Interfaces;
using WebApplicationExample.Models.Command_Models.Category;

namespace WebApplicationExample.Pages.Category
{
    public class UpdateModel : PageModel
    {
        private ICategoryService _categoryService;
        private AppDbContext _appDbContext;

        [BindProperty]
        public UpdateCategoryCommand Command { get; set; }

        public UpdateModel(ICategoryService categoryService, AppDbContext appDbContext)
        {
            _categoryService = categoryService;
            _appDbContext = appDbContext;
        }

        public async Task OnGet(int id)
        {
            var category = await _appDbContext.Categories.FindAsync(id)
                ?? throw new Exception($"There is no category with id:{id} in the database.");

            Command = new UpdateCategoryCommand
            {
                Name = category.Name,
            };
        }

        public async Task<IActionResult> OnPost(int id)
        {
            await _categoryService.UpdateCategoryAsync(id, Command);
            return RedirectToPage("All");
        }
    }
}
