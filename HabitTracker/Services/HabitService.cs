using HabitTracker.Data;
using HabitTracker.Data.Entities;
using HabitTracker.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Services;

public class HabitService : BaseService, IHabitService
{
    public HabitService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider)
        : base(context, authenticationStateProvider)
    {
    }

    public async Task CreateHabitAsync(Habit habit, List<DayOfWeek>? dayOfWeeks)
    {
        var userId = await GetCurrentUserIdAsync();

        habit.UserId = userId;

        await _context.Habits.AddAsync(habit);
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

                await _context.Frequencies.AddAsync(frequency);
                var record = new HabitRecord
                {
                    Date = currentDate.Date.AddDays(-(int)currentDate.DayOfWeek).AddDays((int)dayOfWeek),
                    HabitId = habit.Id
                };
                await _context.Records.AddAsync(record);
            }
        }

        await _context.SaveChangesAsync();
    }

    public async Task DeleteHabitAsync(Guid id)
    {
        var habit = await _context.Habits.FindAsync(id) ?? throw new Exception("Помилка: звичку не знайдено");
        var userId = await GetCurrentUserIdAsync();

        if (habit.UserId != userId)
        {
            throw new Exception("Помилка: відмовлено у доступі");
        }

        var entry = await _context.Habits.FindAsync(habit.Id);
        if (entry != null)
        {
            _context.Habits.Remove(entry);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<List<ApplicationUser>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<Habit> GetHabitByIdAsync(Guid id)
        => await GetUserHabits().FirstOrDefaultAsync(h => h.Id == id) ?? throw new Exception("Помилка: звичку не знайдено");

    public async Task<List<Habit>> GetHabitForUserAsync(string userId, DayOfWeek dayOfWeek)
    {
        return await _context.Habits
            .Include(h => h.Frequencies)
            .Where(h => h.UserId == userId)
            .Where(h => h.StartDate <= DateTime.Now && (h.EndDate == null || h.EndDate >= DateTime.Now))
            .Where(h => h.Frequencies.Any(f => f.DayOfWeek == dayOfWeek))
            .ToListAsync();
    }

    public async Task<List<Habit>> GetHabitsAsync()
        => await GetUserHabits().ToListAsync();

    public async Task UpdateHabitAsync(Habit habit, List<DayOfWeek>? dayOfWeeks)
    {
        var userId = await GetCurrentUserIdAsync();
        habit.UserId = userId;

        if (!habit.IsCompleted)
        {
            habit.EndDate = DateTime.Now;
        }

        if (dayOfWeeks is not null)
        {
            var frequencies = await _context.Frequencies
                .Where(f => f.HabitId == habit.Id)
                .ToListAsync();

            _context.Frequencies.RemoveRange(frequencies);

            foreach (var dayOfWeek in dayOfWeeks)
            {
                var frequency = new HabitFrequency
                {
                    DayOfWeek = dayOfWeek,
                    HabitId = habit.Id
                };

                await _context.Frequencies.AddAsync(frequency);
            }
        }

        var entry = _context.Habits.Entry(habit);
        if (entry.State == EntityState.Detached)
        {
            _context.Habits.Attach(habit);
            entry.State = EntityState.Modified;
        }

        await _context.SaveChangesAsync();
    }

    private IQueryable<Habit> GetUserHabits()
    {
        var userId = GetCurrentUserIdAsync().Result;

        return _context.Habits
            .Include(h => h.Color)
            .Include(h => h.Frequencies)
            .Include(h => h.Records)
            .Where(h => h.UserId == userId);
    }
}
