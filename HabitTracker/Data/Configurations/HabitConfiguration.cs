using HabitTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Data.Configurations;

public class HabitConfiguration : IEntityTypeConfiguration<Habit>
{
    public void Configure(EntityTypeBuilder<Habit> builder)
    {
        builder.ToTable("Habits");
        builder.HasOne(h => h.User)
            .WithMany(u => u.Habits)
            .HasForeignKey(h => h.UserId);

        builder.HasOne(h => h.Color)
            .WithMany(c => c.Habits)
            .HasForeignKey(h => h.ColorId);

        builder.HasMany(h => h.Frequencies)
            .WithOne(f => f.Habit)
            .HasForeignKey(f => f.HabitId);

        builder.HasMany(h => h.Records)
            .WithOne(r => r.Habit)
            .HasForeignKey(r => r.HabitId);

        builder.Property(h => h.Title)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(h => h.Description)
            .HasMaxLength(200);
    }
}
