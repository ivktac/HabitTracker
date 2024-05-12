using HabitTracker.Data;
using Microsoft.AspNetCore.Identity;

namespace HabitTracker.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Помилка: Не вдалося завантажити користувача з ідентифікатором '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
