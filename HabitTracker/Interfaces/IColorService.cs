using HabitTracker.Data.Entities;

namespace HabitTracker.Interfaces;

public interface IColorService
{
    Task<List<Color>> GetColorsAsync();

    Task<Color> GetColorByIdAsync(Guid id);
}
