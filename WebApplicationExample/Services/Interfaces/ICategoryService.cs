using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.Category;
using WebApplicationExample.Models.Domain_Models;

namespace WebApplicationExample.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<int> CreateCategoryAsync(CreateCategoryCommand cmd);
        public Task UpdateCategoryAsync(int categoryId, UpdateCategoryCommand cmd);
        public Task<IList<Category>> GetCategoriesAsync(bool showDeleted = false);
        public Task<Category> GetCategoryByIdAsync(int categoryId);
        public Task DeleteCategoryAsync(int categoryId);
    }
}
