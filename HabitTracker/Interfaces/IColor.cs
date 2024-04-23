using HabitTracker.Data.Entities;

namespace HabitTracker.Interfaces;

public interface IColor
{
    Task<List<Color>> GetColorsAsync();

    Task<Color> GetColorByIdAsync(Guid id);
}
