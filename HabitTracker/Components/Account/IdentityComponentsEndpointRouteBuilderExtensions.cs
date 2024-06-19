using HabitTracker.Components.Account.Pages;
using HabitTracker.Components.Account.Pages.Manage;
using HabitTracker.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Security.Claims;
using System.Text.Json;

namespace Microsoft.AspNetCore.Routing
{
    internal static class IdentityComponentsEndpointRouteBuilderExtensions
    {
        public static IEndpointConventionBuilder MapAdditionalIdentityEndpoints(this IEndpointRouteBuilder endpoints)
        {
            ArgumentNullException.ThrowIfNull(endpoints);

            var accountGroup = endpoints.MapGroup("/Account");
            accountGroup.MapLogoutEndpoint();
            accountGroup.MapManageEndpoints();

            return accountGroup;
        }
    
        private static void MapLogoutEndpoint(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapPost("/Logout", async (ClaimsPrincipal user, SignInManager<ApplicationUser> signInManager, [FromForm] string returnUrl) =>
            {
                await signInManager.SignOutAsync();
                return TypedResults.LocalRedirect($"~/{returnUrl}");
            });
        }

        private static void MapManageEndpoints(this IEndpointRouteBuilder endpoints)
        {
            var manageGroup = endpoints.MapGroup("/Manage").RequireAuthorization();
            var loggerFactory = endpoints.ServiceProvider.GetRequiredService<ILoggerFactory>();

            manageGroup.MapDownloadPersonalDataEndpoint(loggerFactory);
        }

        private static void MapDownloadPersonalDataEndpoint(this IEndpointRouteBuilder endpoints, ILoggerFactory loggerFactory)
        {
            var downloadLogger = loggerFactory.CreateLogger("DownloadPersonalData");

            endpoints.MapPost("/DownloadPersonalData", async (HttpContext context, UserManager<ApplicationUser> userManager, AuthenticationStateProvider authenticationStateProvider) =>
            {
                var user = await userManager.GetUserAsync(context.User);
                if (user is null)
                {
                    return Results.NotFound($"Unable to load user with ID '{userManager.GetUserId(context.User)}'.");
                }


                var userId = await userManager.GetUserIdAsync(user);
                downloadLogger.LogInformation("User with ID '{UserId}' asked for their personal data.", userId);

                var personalData = await CollectPersonalData(userManager, user);
                var fileBytes = JsonSerializer.SerializeToUtf8Bytes(personalData);

                context.Response.Headers.TryAdd("Content-Disposition", "attachment; filename=PersonalData.json");
                return TypedResults.File(fileBytes, contentType: "application/json", fileDownloadName: "PersonalData.json");

            });
        }

        private static async Task<Dictionary<string, string>> CollectPersonalData(UserManager<ApplicationUser> userManager, ApplicationUser user)
        {
            var personalData = new Dictionary<string, string>();
            var personalDataProps = typeof(ApplicationUser).GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(PersonalDataAttribute)));

            foreach (var prop in personalDataProps)
            {
                personalData[prop.Name] = prop.GetValue(user)?.ToString() ?? "null";
            }

            var logins = await userManager.GetLoginsAsync(user);
            foreach (var login in logins)
            {
                personalData[$"{login.LoginProvider} external login provider key"] = login.ProviderKey;
            }

            personalData["Authenticator Key"] = await userManager.GetAuthenticatorKeyAsync(user) ?? string.Empty;

            return personalData;
        }
    }
}
