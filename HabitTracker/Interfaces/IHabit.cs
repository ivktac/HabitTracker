using HabitTracker.Data.Entities;

namespace HabitTracker.Interfaces;

public interface IHabit
{
    Task CreateHabitAsync(Habit habit, List<DayOfWeek>? dayOfWeeks);

    Task<Habit> GetHabitByIdAsync(Guid id);

    Task DeleteHabitAsync(Habit habit);

    Task UpdateHabitAsync(Habit habit);

    Task<List<Habit>> GetHabitsAsync();

    Task<List<Habit>> GetUncompletedHabitsAsync();
}
