using HabitTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Data.Configurations;

public class HabitFrequencyConfiguration : IEntityTypeConfiguration<HabitFrequency>
{
    public void Configure(EntityTypeBuilder<HabitFrequency> builder)
    {
        builder.ToTable("Frequencies");

        builder.HasOne(f => f.Habit)
            .WithMany(h => h.Frequencies)
            .HasForeignKey(f => f.HabitId);

        builder.Property(f => f.DayOfWeek)
            .HasConversion<int>();
    }
}