using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HabitTracker.Data.Entities;

public class Challenge
{
    [Key]
    public Guid Id { get; set; }
    
    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string CreatedById { get; set; } = string.Empty;

    [JsonIgnore]
    public ApplicationUser CreatedBy { get; set; } = null!;

    [JsonIgnore]
    public List<Participant> Participants { get; set; } = [];
}
