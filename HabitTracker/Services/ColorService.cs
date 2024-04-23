using HabitTracker.Data;
using HabitTracker.Data.Entities;
using HabitTracker.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Services
{
    public class ColorService(ApplicationDbContext context) : IColor
    {
        public async Task<List<Color>> GetColorsAsync()
        {
            return await context.Colors.ToListAsync();
        }

        public async Task<Color> GetColorByIdAsync(Guid id)
        {
            return await context.Colors.FindAsync(id) ?? throw new Exception("Color not found");
        }
    }
}
