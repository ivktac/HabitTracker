using HabitTracker.Data;
using HabitTracker.Data.Entities;
using HabitTracker.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Services;

public class ChallengeService : BaseService, IChallengeService
{
    public ChallengeService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider) : base(context, authenticationStateProvider)
    {
    }

    public async Task CreateChallengeAsync(Challenge challenge)
    {
        var userId = await GetCurrentUserIdAsync();
        if (userId is null)
        {
            throw new Exception("Помилка: користувач не знайдений");
        }

        challenge.CreatedById = userId;

        _context.Challenges.Add(challenge);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Challenge>> GetAllChallengesAsync()
    {
        return await _context.Challenges.Include(c => c.Participants).ToListAsync();
    }

    public async Task<Challenge?> GetChallengeByIdAsync(Guid id)
    {
        return await _context.Challenges.
             Include(c => c.Participants)
             .ThenInclude(p => p.User)
             .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<List<Challenge>> GetUserChallengesAsync()
    {
        var userId = await GetCurrentUserIdAsync();
        if (userId is null)
        {
            return [];
        }

        return await _context.Challenges
            .Where(c => c.CreatedById == userId || c.Participants.Any(p => p.UserId == userId))
            .Include(c => c.Participants)
            .ToListAsync();
    }

    public async Task<bool> IsUserInChallenge(Challenge challenge)
    {
        var userId = await GetCurrentUserIdAsync();
        if (userId is null)
        {
            return false;
        }

        return challenge.Participants.Any(p => p.UserId == userId);
    }

    public async Task JoinChallengeAsync(Guid challengeId)
    {
        var userId = await GetCurrentUserIdAsync();
        if (userId is null)
        {
            throw new Exception("Помилка: користувач не знайдений");
        }

        if (await _context.Participants.AnyAsync(p => p.ChallengeId == challengeId && p.UserId == userId))
        {
            return;
        }

        var participant = new Participant
        {
            ChallengeId = challengeId,
            UserId = userId
        };

        _context.Participants.Add(participant);
        await _context.SaveChangesAsync();
    }
}
