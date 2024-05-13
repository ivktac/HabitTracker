namespace HabitTracker.Data.Email;

internal sealed class EmailSettings
{
    public const string Section = "EmailSettings";

    public string DefaultFromEmail { get; set; } = string.Empty;

    public SmtpSettings SmtpSettings { get; set; } = new();
}
