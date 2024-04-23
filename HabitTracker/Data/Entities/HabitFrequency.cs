using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace HabitTracker.Data.Entities;

public class HabitFrequency
{
    [Key]
    public Guid Id { get; set; }

    public Guid HabitId { get; set; }
    public Habit Habit { get; set; } = null!;

    public DayOfWeek DayOfWeek { get; set; }

    [NotMapped]
    public string DayOfWeekString
    {
        get
        {
            var culture = CultureInfo.GetCultureInfo("uk_UA");
            return culture.DateTimeFormat.GetShortestDayName(DayOfWeek);
        }
    }
}
