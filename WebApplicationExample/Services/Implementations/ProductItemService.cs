using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.ProductItem;
using WebApplicationExample.Models.Domain_Models;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Services.Implementations
{
    public class ProductItemService : IProductItemService
    {
        private readonly AppDbContext _context;

        public ProductItemService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateProductItemAsync(CreateProductItemCommand cmd)
        {
            var productItem = new ProductItem
            {
                ProductId = cmd.ProductId,
                SizeId = cmd.SizeId,
                ColorId = cmd.ColorId,
                CategoryId = cmd.CategoryId,
            };

            await _context.ProductItems.AddAsync(productItem);
            await _context.SaveChangesAsync();
            return productItem.ProductItemId;
        }

        public async Task DeleteProductItemAsync(int productItemId)
        {
            var productItem = await _context.ProductItems.FindAsync(productItemId)
                ?? throw new System.Exception($"There is no product-imte with id:{productItemId} in the database.");

            productItem.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<IList<ProductItem>> GetProductItemsAsync(bool showDeleted = false)
        {
            var productItemsQueryable = _context.ProductItems.OrderBy(pI => pI.ProductItemId);

            if (showDeleted)
            {
                return await productItemsQueryable.ToListAsync();
            }
            else
            {
                return await productItemsQueryable.Where(pI => !pI.IsDeleted).ToListAsync();
            }
        }

        public async Task UpdateProductItemAsync(int productItemId, UpdateProductItemCommand cmd)
        {
            var productItem = await _context.ProductItems.FindAsync(productItemId)
                ?? throw new System.Exception($"There is no product-item with id:{productItemId} in the database.");

            productItem.ProductId = cmd.ProductId;
            productItem.SizeId = cmd.SizeId;
            productItem.ColorId = cmd.ColorId;
            productItem.CategoryId = cmd.CategoryId;

            await _context.SaveChangesAsync();
        }
    }
}
