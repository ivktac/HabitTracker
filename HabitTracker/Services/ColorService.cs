using HabitTracker.Data;
using HabitTracker.Data.Entities;
using HabitTracker.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Services
{
    public class ColorService(ApplicationDbContext context) : IColorService
    {
        public async Task<List<Color>> GetColorsAsync() => await context.Colors.ToListAsync();

        public async Task<Color> GetColorByIdAsync(Guid id) => await context.Colors.FindAsync(id) ?? throw new Exception("Помилка: колір не знайдено");
    }
}
