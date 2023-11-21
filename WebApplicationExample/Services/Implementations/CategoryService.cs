using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.Category;
using WebApplicationExample.Models.Domain_Models;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateCategoryAsync(CreateCategoryCommand cmd)
        {
            var category = new Category
            {
                Name = cmd.Name,
            };

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category.CategoryId;
        }

        public async Task DeleteCategoryAsync(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId)
                ?? throw new System.Exception($"There is no category with id:{categoryId} in the database");

            category.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Category>> GetCategoriesAsync(bool showDeleted = false)
        {
            var categoriesQueryable = _context.Categories.OrderBy(c => c.CategoryId);

            if (showDeleted)
            {
                return await categoriesQueryable.ToListAsync();
            }
            else
            {
                return await _context.Categories.Where(c => !c.IsDeleted).ToListAsync();
            }
        }

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
        {
            var category = await _context.Categories.Where(c => c.CategoryId == categoryId).SingleOrDefaultAsync()
                ?? throw new Exception($"There is no category with id:{categoryId} in the database.");

            return category;
        }

        public async Task UpdateCategoryAsync(int categoryId, UpdateCategoryCommand cmd)
        {
            var category = await _context.Colors.FindAsync(categoryId)
                ?? throw new Exception($"There is no color with id:{categoryId} in the database.");

            category.Name = cmd.Name;
            await _context.SaveChangesAsync();
        }
    }
}