
using FluentEmail.Core;
using HabitTracker.Interfaces;

namespace HabitTracker.Services;

public class DailyEmailService(IServiceProvider serviceProvider, IFluentEmailFactory emailFactory, ILogger<DailyEmailService> logger) : BackgroundService
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;
    private readonly IFluentEmailFactory _emailFactory = emailFactory;
    private readonly ILogger<DailyEmailService> _logger = logger;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var timer = new Timer(async state =>
        {
            await SendDailyEmails();
        }, null, NextRuntime, TimeSpan.FromDays(1));
    }

    private TimeSpan NextRuntime
    {
        get
        {
            var now = DateTime.Now;
            var nextRunTime = new DateTime(now.Year, now.Month, now.Day, 6, 0, 0, DateTimeKind.Local);

            if (now > nextRunTime)
                nextRunTime = nextRunTime.AddDays(1);

            return nextRunTime - now;
        }
    }

    private async Task SendDailyEmails()
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            var habitService = scope.ServiceProvider.GetRequiredService<IHabitService>();
            var users = await habitService.GetAllUsersAsync();

            foreach (var user in users)
            {
                try
                {
                    var habits = await habitService.GetHabitForUserAsync(user.Id, DateTime.Now.DayOfWeek);
                    var habitList = string.Join("<br>", habits.Select(h => h.Title));

                    var emailMessage = _emailFactory.Create()
                        .To(user.Email)
                        .Subject("Ваші щоденні звички")
                        .Body($"Ваші звички на сьогодні: <br>{habitList}", true);

                    await emailMessage.SendAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error sending email to {user.Email}: {ex.Message}");
                }
            }
        }
    }
}
