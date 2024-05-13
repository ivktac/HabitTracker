using HabitTracker.Data.Entities;

namespace HabitTracker.Interfaces;

public interface IHabitStatus
{
    Task<int > CalculateProgressThisWeek();
}
