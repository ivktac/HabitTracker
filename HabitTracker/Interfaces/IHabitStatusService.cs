namespace HabitTracker.Interfaces;

public interface IHabitStatusService
{
    Task<int > CalculateProgressThisWeek();
}
