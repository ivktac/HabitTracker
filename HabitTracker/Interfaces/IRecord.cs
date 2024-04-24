using HabitTracker.Data.Entities;

namespace HabitTracker.Interfaces;

public interface IRecord
{
    Task<List<HabitRecord>> GetThisWeek();

    Task<List<HabitRecord>> GetToday();

    Task<int> GetProgressDoneWeek();

    Task MarkAsComplete();

    Task CreateRecord(Guid habitId);
}
