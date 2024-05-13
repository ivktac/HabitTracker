using HabitTracker.Data;
using HabitTracker.Data.Entities;
using HabitTracker.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HabitTracker.Services;

public class HabitStatusService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider) : IHabitStatus
{
    private async Task<string?> GetUserIdAsync()
    {
        var authState = await authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        string? userId = null;

        if (user.Identity is not null && user.Identity.IsAuthenticated)
        {
            userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        return userId;
    }

    public async Task<int> CalculateProgressThisWeek()
    {
        var userId = await GetUserIdAsync();
        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("User not found");
        }

        var habits = await context.Habits
            .Include(h => h.Frequencies)
            .Where(h => h.UserId == userId)
            .ToListAsync();

        int total = 0;
        int completed = 0;

        var today = DateTime.Now;
        var startOfWeek = today.Date.AddDays(-(int)today.DayOfWeek);
        var endOfWeek = startOfWeek.AddDays(6);

        foreach (var habit in habits)
        {
            var featureRecords = await context.Frequencies
                .Where(f => f.HabitId == habit.Id)
                .Select(f => f.DayOfWeek)
                .ToListAsync();

            var records = await context.Records
                .Where(r => r.HabitId == habit.Id)
                .Where(r => r.Date >= startOfWeek && r.Date <= endOfWeek)
                .ToListAsync();

            total += featureRecords.Count;
            completed += records.Count(r => r.IsDone);
        }

        return total == 0 ? 0 : (completed * 100) / total;
    }
}
