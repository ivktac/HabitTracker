using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HabitTracker.Data.Entities;

public class Category
{
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    [JsonIgnore]
    public List<Habit> Habits { get; set; } = [];
}
