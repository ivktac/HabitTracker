using HabitTracker.Data.Entities;

namespace HabitTracker.Interfaces;

public interface IRecord
{
    Task<int> GetProgressDoneWeek(DateTime dateTime);

    Task MarkAsComplete(Guid habitId, bool completed, DateTime? date = null);
}
