using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    [JsonIgnore]

    public List<HabitFrequency> Frequencies { get; set; } = [];
    [JsonIgnore]
    public List<HabitRecord> Records { get; set; } = [];


    [NotMapped]
    public HabitRecord TodayRecord => GetRecord(DateTime.Now);

    public HabitRecord GetRecord(DateTime date)
    {
        var isPeristence = StartDate <= date && (EndDate == null || EndDate >= date);
        if (!isPeristence)
        {
            return new HabitRecord();
        }

        var record = Records.FirstOrDefault(r => r.Date.Date == date.Date);
        return record ?? new HabitRecord();
    }

    [NotMapped]
    public string HexCode => Color.Code;

    [NotMapped]
    public string CategoryName => Category?.Name ?? string.Empty;

}