using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HabitTracker.Data.Entities;

public class Participant
{
    [Key]
    public Guid Id { get; set; }

    public Guid ChallengeId { get; set; }

    [JsonIgnore]
    public Challenge Challenge { get; set; } = null!;

    public string UserId { get; set; } = string.Empty;

    [JsonIgnore]
    public ApplicationUser User { get; set; } = null!;
}
