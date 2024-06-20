using HabitTracker.Data;
using HabitTracker.Data.Entities;
using HabitTracker.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HabitTracker.Services;

public class RecordService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider) : IRecordService
{
    private async Task<string?> GetUserIdAsync()
    {
        var authState = await authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        string? userId = null;

        Console.WriteLine(user.Identity?.IsAuthenticated);
        Console.WriteLine(user.Identity?.Name);

        if (user.Identity is not null && user.Identity.IsAuthenticated)
        {
            userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        return userId;
    }

    public async Task<int> GetProgressDoneWeek(DateTime dateTime)
    {
        var userId = await GetUserIdAsync();

        if (string.IsNullOrEmpty(userId)) {
            throw new Exception("User not found");
        }

        var startOfWeek = dateTime.DayOfWeek == DayOfWeek.Sunday
            ? dateTime.Date
            : dateTime.Date.AddDays(-(int)dateTime.DayOfWeek);

        var endOfWeek = startOfWeek.AddDays(6);

        var records = await context.Records
            .Where(r => r.Habit.UserId == userId)
            .Where(r => r.Date >= startOfWeek && r.Date <= endOfWeek)
            .ToListAsync();

        return records.Count;

    }

    public async Task MarkAsComplete(Guid habitId, bool completed, DateTime? date = null)
    {
        var userId = await GetUserIdAsync();
        var current = date ?? DateTime.Now;

        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("User not found");
        }

        var habit = await context.Habits.FindAsync(habitId) ?? throw new Exception("Habit not found");

        if (habit.UserId != userId)
        {
            throw new Exception("Habit not found");
        }

        if (habit.StartDate > current || (habit.EndDate is not null && habit.EndDate < current))
        {
            return;
        }

        var record = await context.Records
            .FirstOrDefaultAsync(r => r.HabitId == habitId && r.Date == current.Date);

        if (record is null)
        {
            record = new HabitRecord
            {
                HabitId = habitId,
                Date = current.Date,
            };

            await context.Records.AddAsync(record);
        }

        record.IsDone = completed;
        await context.SaveChangesAsync();
    }

    public async Task<int> GetHabitStreak(Guid habitId)
    {
        var userId = await GetUserIdAsync();

        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("User not found");
        }

        var habit = await context.Habits.FindAsync(habitId) ?? throw new Exception("Habit not found");

        if (habit.UserId != userId)
        {
            throw new Exception("Habit not found");
        }

        var records = await context.Records
            .Where(r => r.HabitId == habitId && r.IsDone)
            .OrderByDescending(r => r.Date)
            .ToListAsync();

        int streak = 0;
        DateTime? previousDate = null;

        foreach (var record in records)
        {
            if (previousDate == null)
            {
                previousDate = record.Date;
            }

            if (record.Date == previousDate)
            {
                streak++;
                previousDate = previousDate.Value.AddDays(-1);
            }
            else
            {
                break;
            }
        }

        return streak;
    }
}
