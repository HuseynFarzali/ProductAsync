using Microsoft.EntityFrameworkCore;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.Product;
using WebApplicationExample.Models.Domain_Models;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Services.Implementations
{
    public class ProductService : IProductService
    {
        private AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateProductAsync(CreateProductCommand cmd)
        {
            var product = new Product
            {
                Name = cmd.Name,
                Price = cmd.Price,
                Rating = cmd.Rating,
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product.ProductId;
        }

        public async Task UpdateProductAsync(int productId, UpdateProductCommand cmd)
        {
            var product = await _context.Products.FindAsync(productId)
                ?? throw new System.Exception($"There is no product with id:{productId} in the database.");

            product.Name = cmd.Name;
            product.Price = cmd.Price;
            product.Rating = cmd.Rating;

            await _context.SaveChangesAsync();
        }

        public async Task<IList<Product>> GetProductsAsync(bool showDeleted = false)
        {
            var productsQueryable = _context.Products.OrderBy(p => p.ProductId);

            if (showDeleted)
            {
                return await productsQueryable.ToListAsync();
            }
            else
            {
                return await productsQueryable.Where(p => !p.IsDeleted).ToListAsync();
            }
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId)
                ?? throw new System.Exception($"There is no product with id:{productId} in the database.");

            product.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var product = await _context.Products
                .Where(p => p.ProductId == productId)
                .Include(p => p.ProductItems)
                .SingleOrDefaultAsync()
                ?? throw new System.Exception($"There is no product with id:{productId} in the database.");

            return product;
        }
    }
}
