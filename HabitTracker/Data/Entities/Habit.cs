using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HabitTracker.Data.Entities;

public class Habit
{
    [Key]
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public Guid ColorId { get; set; }

    public Color Color { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public bool IsCompleted { get; set; }

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    public List<HabitFrequency> Frequencies { get; set; } = [];


    [NotMapped]
    public string HexCode => Color.Code;
}