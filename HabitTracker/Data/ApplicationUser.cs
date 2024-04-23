using HabitTracker.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace HabitTracker.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public List<Habit> Habits { get; set; } = [];
    }
}
