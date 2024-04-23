using System.ComponentModel.DataAnnotations;

namespace HabitTracker.Data.Entities;

public class Color
{
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Code { get; set; }

    public List<Habit> Habits { get; set; } = [];
}
