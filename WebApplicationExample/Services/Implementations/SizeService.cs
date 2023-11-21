using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.Size;
using WebApplicationExample.Models.Domain_Models;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Services.Implementations
{
    public class SizeService : ISizeService
    {
        private AppDbContext _context;

        public SizeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateSizeAsync(CreateSizeCommand cmd)
        {
            var size = new Size
            {
                Name = cmd.Name
            };

            await _context.Sizes.AddAsync(size);
            await _context.SaveChangesAsync();
            return size.SizeId;
        }

        public async Task UpdateSizeAsync(int sizeId, UpdateSizeCommand cmd)
        {
            var size = await _context.Sizes.FindAsync(sizeId)
                ?? throw new System.Exception($"There is no size with id:{sizeId} in the database.");

            size.Name = cmd.Name;

            await _context.SaveChangesAsync();
        }

        public async Task<IList<Size>> GetSizesAsync(bool showDeleted = false)
        {
            var sizesQuaryble = _context.Sizes.OrderBy(s => s.SizeId);

            if (showDeleted)
            {
                return await sizesQuaryble.ToListAsync();
            }
            else
            {
                return await sizesQuaryble.Where(s => !s.IsDeleted).ToListAsync();
            }
        }

        public async Task DeleteSizeAsync(int sizeId)
        {
            var size = await _context.Sizes.FindAsync(sizeId)
                ?? throw new System.Exception($"There is no size with id:{sizeId} in the database.");

            size.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Size> GetSizeByIdAsync(int sizeId)
        {
            var size = await _context.Sizes.Where(s => s.SizeId == sizeId).SingleOrDefaultAsync()
                ?? throw new System.Exception($"There is no size with id:{sizeId} in the database.");

            return size;
        }
    }
}
