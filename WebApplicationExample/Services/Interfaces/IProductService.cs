using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.Product;
using WebApplicationExample.Models.Domain_Models;

namespace WebApplicationExample.Services.Interfaces
{
    public interface IProductService
    {
        public Task<int> CreateProductAsync(CreateProductCommand cmd);
        public Task UpdateProductAsync(int productId, UpdateProductCommand cmd);
        public Task DeleteProductAsync(int productId);
        public Task<IList<Product>> GetProductsAsync(bool showDeleted = false);
        public Task<Product> GetProductByIdAsync(int productId);
    }
}
