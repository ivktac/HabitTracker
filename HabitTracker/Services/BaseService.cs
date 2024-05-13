using HabitTracker.Data;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace HabitTracker.Services;

public abstract class BaseService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider)
{
    protected readonly ApplicationDbContext _context = context;
    protected readonly AuthenticationStateProvider _authenticationStateProvider = authenticationStateProvider;

    protected async Task<string> GetCurrentUserIdAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        
        var userId = user.Identity?.IsAuthenticated == true ? user.FindFirst(ClaimTypes.NameIdentifier)?.Value : null;
    
        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("Помилка: відмовлено у доступі");
        }

        return userId;
    }
}
