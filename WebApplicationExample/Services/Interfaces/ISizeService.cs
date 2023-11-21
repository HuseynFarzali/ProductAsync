using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.Size;
using WebApplicationExample.Models.Domain_Models;

namespace WebApplicationExample.Services.Interfaces
{
    public interface ISizeService
    {
        public Task<int> CreateSizeAsync(CreateSizeCommand cmd);
        public Task UpdateSizeAsync(int sizeId, UpdateSizeCommand cmd);
        public Task<IList<Size>> GetSizesAsync(bool showDeleted = false);
        public Task<Size> GetSizeByIdAsync(int sizeId);
        public Task DeleteSizeAsync(int sizeId);
    }
}
