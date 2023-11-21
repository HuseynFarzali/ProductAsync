using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.ProductItem;
using WebApplicationExample.Models.Domain_Models;

namespace WebApplicationExample.Services.Interfaces
{
    public interface IProductItemService
    {
        public Task<int> CreateProductItemAsync(CreateProductItemCommand cmd);
        public Task UpdateProductItemAsync(int productItemId, UpdateProductItemCommand cmd);
        public Task DeleteProductItemAsync(int productItemId);
        public Task<IList<ProductItem>> GetProductItemsAsync(bool showDeleted = false);
    }
}
