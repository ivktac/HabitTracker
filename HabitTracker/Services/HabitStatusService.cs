using HabitTracker.Data;
using HabitTracker.Data.Entities;
using HabitTracker.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HabitTracker.Services;

public class HabitStatusService : BaseService, IHabitStatusService
{
    public HabitStatusService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider)
        : base(context, authenticationStateProvider)
    {
    }

    public async Task<int> CalculateProgressThisWeek()
    {
        var userId = await GetCurrentUserIdAsync();

        var habits = await GetUserHabits().ToListAsync();

        int total = 0;
        int completed = 0;

        var today = DateTime.Now.Date;
        var startOfWeek = today.AddDays(-(int)today.DayOfWeek);
        var endOfWeek = startOfWeek.AddDays(6);

        foreach (var habit in habits)
        {
            var featureRecords = await _context.Frequencies
                .Where(f => f.HabitId == habit.Id)
                .Select(f => f.DayOfWeek)
                .ToListAsync();

            var records = await GetRecordsFilteredByDate(habit.Id, startOfWeek, endOfWeek);

            total += featureRecords.Count;
            completed += records.Count(r => r.IsDone);
        }

        return total == 0 ? 0 : completed * 100 / total;
    }

    private IQueryable<Habit> GetUserHabits()
    {
        var userId = GetCurrentUserIdAsync().Result;

        return _context.Habits
            .Include(h => h.Frequencies)
            .Where(h => h.UserId == userId);
    }

    private async Task<List<HabitRecord>> GetRecordsFilteredByDate(Guid habitId, DateTime startDate, DateTime endDate)
        => await _context.Records
            .Where(r => r.HabitId == habitId && r.Date >= startDate && r.Date <= endDate)
            .ToListAsync();
}
