using HabitTracker.Components.Account;
using HabitTracker.Data;
using HabitTracker.Data.Email;
using HabitTracker.Interfaces;
using HabitTracker.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace HabitTracker;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddBlazor();

        services.AddDatabase(configuration);
        
        services.AddAuth();

        services.AddEmailService(configuration);

        services.AddRequiredServices();
        
        return services;
    }

    private static IServiceCollection AddEmailService(this IServiceCollection services, IConfiguration configuration)
    {
        var emailSettings = new EmailSettings();
        configuration.Bind(EmailSettings.Section, emailSettings);

        services.AddFluentEmail(emailSettings.DefaultFromEmail)
            .AddSmtpSender(new SmtpClient(emailSettings.SmtpSettings.Host)
            {
                Port = emailSettings.SmtpSettings.Port
                // Credentials = new NetworkCredential(emailSettings.SmtpSettings.Username, emailSettings.SmtpSettings.Password)
            });

        services.AddSingleton<IEmailSender<ApplicationUser>, SmtpEmailSender>();

        services.AddHostedService<DailyEmailService>();

        return services;
    }

    private static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddDatabaseDeveloperPageExceptionFilter();

        return services;
    }

    private static IServiceCollection AddAuth(this IServiceCollection services)
    {
        services.AddCascadingAuthenticationState();

        services.AddScoped<IdentityUserAccessor>();
        services.AddScoped<IdentityRedirectManager>();
        services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

        services.AddAuthentication(options =>
        {
            options.DefaultScheme = IdentityConstants.ApplicationScheme;
            options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
        }).AddIdentityCookies();

        services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();

        return services;
    }

    private static IServiceCollection AddBlazor(this IServiceCollection services)
    {
        services.AddRazorComponents()
            .AddInteractiveServerComponents();

        return services;
    }

    private static IServiceCollection AddRequiredServices(this IServiceCollection services)
    {
        services.AddScoped<IHabit, HabitService>();
        services.AddScoped<IHabitStatus, HabitStatusService>();
        services.AddScoped<IColor, ColorService>();
        services.AddScoped<IRecord, RecordService>();

        return services;
    }
}
