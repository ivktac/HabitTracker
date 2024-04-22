using HabitTracker.Components;
using HabitTracker.Components.Account;
using HabitTracker.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

EmailSettings emailSettings = new();
builder.Configuration.Bind(EmailSettings.Section, emailSettings);

builder.Services
    .AddFluentEmail(emailSettings.DefaultFromEmail)
    .AddSmtpSender(new SmtpClient(emailSettings.SmtpSettings.Host)
    {
        Port = emailSettings.SmtpSettings.Port
        // Credentials = new NetworkCredential(emailSettings.SmtpSettings.Username, emailSettings.SmtpSettings.Password)
    });

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, SmtpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();

internal sealed class EmailSettings
{
    public const string Section = "EmailSettings";

    public string DefaultFromEmail { get; set; } = string.Empty;

    public SmtpSettings SmtpSettings { get; set; } = null!;
}

internal sealed class SmtpSettings
{
    public string Host { get; init; } = string.Empty;
    public int Port { get; init; }
    public string Username { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}
