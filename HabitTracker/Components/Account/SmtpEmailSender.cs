using FluentEmail.Core;
using HabitTracker.Data;
using Microsoft.AspNetCore.Identity;

namespace HabitTracker.Components.Account
{
    internal sealed class SmtpEmailSender(IFluentEmailFactory emailFactory) : IEmailSender<ApplicationUser>
    {

        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink) =>
            SendEmailAsync(email, "Confirm your email", $"ϳ��������� ��� �������� ����� <a href='{confirmationLink}'>���������� ���</a>.");

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink) =>
            SendEmailAsync(email, "Reset your password", $"���� �����, ������� ��� ������ <a href='{resetLink}'>���������� ���</a>.");

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
            SendEmailAsync(email, "Reset your password", $"���� �����, ������� ��� ������ �� ��������� ���������� ����: {resetCode}");

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
