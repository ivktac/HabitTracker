using HabitTracker.Data.Entities;

namespace HabitTracker.Interfaces;

public interface IHabit
{
    Task CreateHabitAsync(Habit habit, List<DayOfWeek>? dayOfWeeks);

    Task<Habit> GetHabitByIdAsync(Guid id);

    Task DeleteHabitAsync(Guid id);

    Task UpdateHabitAsync(Habit habit, List<DayOfWeek>? dayOfWeeks);

    Task<List<Habit>> GetHabitsAsync();
}
