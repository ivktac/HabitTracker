using FluentEmail.Core;
using HabitTracker.Data;
using Microsoft.AspNetCore.Identity;

namespace HabitTracker.Components.Account
{
    internal sealed class SmtpEmailSender(IFluentEmailFactory emailFactory) : IEmailSender<ApplicationUser>
    {

        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink) =>
            SendEmailAsync(email, "Confirm your email", $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.");

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink) =>
            SendEmailAsync(email, "Reset your password", $"Please reset your password by <a href='{resetLink}'>clicking here</a>.");

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
            SendEmailAsync(email, "Reset your password", $"Please reset your password using the following code: {resetCode}");

        private async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailMessage = emailFactory.Create()
                .To(email)
                .Subject(subject)
                .Body(htmlMessage, true);

            await emailMessage.SendAsync();
        }
    }
}
