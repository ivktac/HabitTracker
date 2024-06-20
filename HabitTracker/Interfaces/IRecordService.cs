namespace HabitTracker.Interfaces;

public interface IRecordService
{
    Task<int> GetProgressDoneWeek(DateTime dateTime);

    Task MarkAsComplete(Guid habitId, bool completed, DateTime? date = null);

    Task<int> GetHabitStreak(Guid habitId);
}
