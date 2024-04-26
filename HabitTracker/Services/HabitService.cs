using HabitTracker.Data;
using HabitTracker.Data.Entities;
using HabitTracker.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HabitTracker.Services;

public class HabitService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider) : IHabit
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

    public async Task CreateHabitAsync(Habit habit, List<DayOfWeek>? dayOfWeeks)
    {
        var userId = await GetUserIdAsync();

        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("User not found");
        }

        habit.UserId = userId;

        await context.Habits.AddAsync(habit);
        if (dayOfWeeks is not null)
        {
            var currentDate = DateTime.Now;
            foreach (var dayOfWeek in dayOfWeeks)
            {
                var frequency = new HabitFrequency
                {
                    DayOfWeek = dayOfWeek,
                    HabitId = habit.Id
                };

                await context.Frequencies.AddAsync(frequency);
                var record = new HabitRecord
                {
                    Date = currentDate.Date.AddDays(-(int)currentDate.DayOfWeek).AddDays((int)dayOfWeek),
                    HabitId = habit.Id
                };
                await context.Records.AddAsync(record);
            }
        }

        await context.SaveChangesAsync();
    }

    public async Task DeleteHabitAsync(Guid id)
    {
        var habit = await context.Habits.FindAsync(id) ?? throw new Exception("Habit not found");
        var userId = await GetUserIdAsync();

        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("User not found");
        }

        if (habit.UserId != userId)
        {
            throw new Exception("Habit not found");
        }

        var entry = await context.Habits.FindAsync(habit.Id);
        if (entry != null)
        {
            context.Habits.Remove(entry);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Habit> GetHabitByIdAsync(Guid id)
    {
        var userId = await GetUserIdAsync();
        if (string.IsNullOrEmpty(userId)) {
            throw new Exception("User not found");
        }

        return await context.Habits
            .Include(h => h.Color)
            .Include(h => h.Frequencies)
            .Include(h => h.Records)
            .Where(h => h.UserId == userId)
            .FirstOrDefaultAsync(h => h.Id == id) ?? throw new Exception("Habit not found");

    }

    public async Task<List<Habit>> GetHabitsAsync()
    {
        var userId = await GetUserIdAsync();

        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("User not found");
        }

        return await context.Habits
            .Include(h => h.Color)
            .Include(h => h.Frequencies)
            .Include(h => h.Records)
            .Where(h => h.UserId == userId)
            .ToListAsync();
    }

    public async Task<List<Habit>> GetUncompletedHabitsAsync()
    {
        var userId = await GetUserIdAsync();

        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("User not found");
        }

        return await context.Habits
            .Include(h => h.Color)
            .Include(h => h.Frequencies)
            .Where(h => h.UserId == userId)
            .Where(h => !h.IsCompleted)
            .ToListAsync();
    }

    public async Task UpdateHabitAsync(Habit habit, List<DayOfWeek>? dayOfWeeks)
    {
        var userId = await GetUserIdAsync();
        if (string.IsNullOrEmpty(userId)) {
            throw new Exception("User not found");
        }

        if (habit.UserId != userId) {
            throw new Exception("Habit not found");
        }

        if (!habit.IsCompleted) {
            habit.EndDate = DateTime.Now;
        }

        habit.UserId = userId;

        if (dayOfWeeks is not null)
        {
            var frequencies = await context.Frequencies
                .Where(f => f.HabitId == habit.Id)
                .ToListAsync();

            context.Frequencies.RemoveRange(frequencies);

            foreach (var dayOfWeek in dayOfWeeks)
            {
                var frequency = new HabitFrequency
                {
                    DayOfWeek = dayOfWeek,
                    HabitId = habit.Id
                };

                await context.Frequencies.AddAsync(frequency);
            }
        }

        var entry = context.Habits.Entry(habit);
        if (entry.State == EntityState.Detached)
        {
            context.Habits.Attach(habit);
            entry.State = EntityState.Modified;
        }

        await context.SaveChangesAsync();
    }

    public Task<int> CalculateHabitStreakAsync(Guid habitId)
    {
        throw new NotImplementedException();
    }

    public async Task<int> CalculateProgressThisWeek()
    {
        var userId = await GetUserIdAsync();
        if (string.IsNullOrEmpty(userId)) {
            throw new Exception("User not found");
        }

        var habits = await context.Habits
            .Include(h => h.Frequencies)
            .Where(h => h.UserId == userId)
            .ToListAsync();

        int total = 0;
        int completed = 0;

        // TODO: complete this code 

        return total == 0 ? 0 : (completed * 100) / total;
    }
}
