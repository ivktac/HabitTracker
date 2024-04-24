using HabitTracker.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Habit> Habits { get; set; }
        
        public DbSet<Color> Colors { get; set; }

        public DbSet<HabitFrequency> Frequencies { get; set; }

        public DbSet<HabitRecord> Records { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Habit>().ToTable("Habits");

            modelBuilder.Entity<Color>().ToTable("Colors");

            modelBuilder.Entity<HabitFrequency>().ToTable("Frequencies");

            modelBuilder.Entity<Habit>()
                .HasOne(h => h.Color)
                .WithMany(c => c.Habits)
                .HasForeignKey(h => h.ColorId);

            modelBuilder.Entity<Habit>()
                .HasOne(h => h.User)
                .WithMany(u => u.Habits)
                .HasForeignKey(h => h.UserId);

            modelBuilder.Entity<HabitFrequency>()
                .HasOne(f => f.Habit)
                .WithMany(h => h.Frequencies)
                .HasForeignKey(f => f.HabitId);

            modelBuilder.Entity<HabitFrequency>()
                .Property(f => f.DayOfWeek)
                .HasConversion<int>();

            modelBuilder.Entity<Color>()
                .HasData(
                    new Color { Id = Guid.NewGuid(), Name = "Red", Code = "#FF0000" },
                    new Color { Id = Guid.NewGuid(), Name = "Green", Code = "#00FF00" },
                    new Color { Id = Guid.NewGuid(), Name = "Blue", Code = "#0000FF" },
                    new Color { Id = Guid.NewGuid(), Name = "Yellow", Code = "#FFFF00" },
                    new Color { Id = Guid.NewGuid(), Name = "Purple", Code = "#800080" },
                    new Color { Id = Guid.NewGuid(), Name = "Orange", Code = "#FFA500" },
                    new Color { Id = Guid.NewGuid(), Name = "Pink", Code = "#FFC0CB" },
                    new Color { Id = Guid.NewGuid(), Name = "Brown", Code = "#A52A2A" },
                    new Color { Id = Guid.NewGuid(), Name = "Black", Code = "#000000" },
                    new Color { Id = Guid.NewGuid(), Name = "White", Code = "#FFFFFF" }
                );
        }
    }
}
