using HabitTracker.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace HabitTracker.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public List<Habit> Habits { get; set; } = [];

        [JsonIgnore]
        public List<Challenge> CreatedChallenges { get; set; } = [];

        [JsonIgnore]
        public List<Participant> JoinedChallenges { get; set; } = [];
    }
}
