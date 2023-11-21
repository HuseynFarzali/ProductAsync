using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationExample.Models.Command_Models.Color;
using WebApplicationExample.Models.Domain_Models;

namespace WebApplicationExample.Services.Interfaces
{
    public interface IColorService
    {
        public Task<int> CreateColorAsync(CreateColorCommand cmd);
        public Task UpdateColorAsync(int colorId, UpdateColorCommand cmd);
        public Task<IList<Color>> GetColorsAsync(bool showDeleted = false);
        public Task<Color> GetColorByIdAsync(int colorId);
        public Task DeleteColorAsync(int colorId);
    }
}
