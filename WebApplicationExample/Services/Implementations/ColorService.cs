using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationExample.Database;
using WebApplicationExample.Models.Command_Models.Color;
using WebApplicationExample.Models.Domain_Models;
using WebApplicationExample.Services.Interfaces;

namespace WebApplicationExample.Services.Implementations
{
    public class ColorService : IColorService
    {
        private AppDbContext _context;

        public ColorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateColorAsync(CreateColorCommand cmd)
        {
            var color = new Color
            {
                Name = cmd.Name,
            };

            await _context.Colors.AddAsync(color);
            await _context.SaveChangesAsync();
            return color.ColorId;
        }

        public async Task UpdateColorAsync(int colorId, UpdateColorCommand cmd)
        {
            var color = await _context.Colors.FindAsync(colorId)
                ?? throw new Exception($"There is no color with id:{colorId} in the database.");

            color.Name = cmd.Name;

            await _context.SaveChangesAsync();
        }

        public async Task<IList<Color>> GetColorsAsync(bool showDeleted = false)
        {
            var colorsQueryable = _context.Colors.OrderBy(c => c.ColorId);

            if (showDeleted)
            {
                return await colorsQueryable.ToListAsync();
            }
            else
            {
                return await colorsQueryable.Where(c => !c.IsDeleted).ToListAsync();
            }
        }

        public async Task DeleteColorAsync(int colorId)
        {
            var color = await _context.Colors.FindAsync(colorId)
                ?? throw new Exception($"There is no color with id:{colorId} in the database.");

            color.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Color> GetColorByIdAsync(int colorId)
        {
            var color = await _context.Colors.Where(c => c.ColorId == colorId).SingleOrDefaultAsync()
                ?? throw new Exception($"There is no color with id:{colorId} in the database.");

            return color;
        }
    }
}
