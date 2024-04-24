using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HabitTracker.Data.Entities;

public class Color
{
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Code { get; set; }

    [JsonIgnore]
    public List<Habit> Habits { get; set; } = [];
}
