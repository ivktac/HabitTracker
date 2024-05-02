using HabitTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Data.Configurations;

public class HabitRecordConfiguration : IEntityTypeConfiguration<HabitRecord>
{
    public void Configure(EntityTypeBuilder<HabitRecord> builder)
    {
        builder.ToTable("Records");

        builder.HasOne(r => r.Habit)
            .WithMany(h => h.Records)
            .HasForeignKey(r => r.HabitId);

        builder.Property(r => r.Date)
            .IsRequired();

        builder.Property(r => r.IsDone)
            .IsRequired();
    }
}
