using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HabitTracker.Data.Entities;

public class HabitRecord
{
    [Key]
    public Guid Id { get; set; }
    public Guid HabitId { get; set; }
    public Habit Habit { get; set; } = null!;
    public DateTime Date { get; set; }
    public bool IsDone { get; set; }
}
