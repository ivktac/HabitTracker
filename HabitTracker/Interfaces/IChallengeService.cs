using HabitTracker.Data.Entities;

namespace HabitTracker.Interfaces;

public interface IChallengeService
{
    Task<List<Challenge>> GetAllChallengesAsync();

    Task<Challenge?> GetChallengeByIdAsync(Guid id);

    Task CreateChallengeAsync(Challenge challenge);

    Task JoinChallengeAsync(Guid challengeId);

    Task<List<Challenge>> GetUserChallengesAsync();

    Task<bool> IsUserInChallenge(Challenge challenge);
}
