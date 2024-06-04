using HabitTracker.Data.Entities;

namespace HabitTracker.Services;

public class HabitStateService
{
    public event Action OnChange;

    public List<Habit> Habits { get; private set; } = [];

    public void UpdateHabits(List<Habit> habits)
    {
        Habits = habits;
        NotifyStateChanged();
    }

    public void NotifyStateChanged() => OnChange?.Invoke();
}
