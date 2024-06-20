using HabitTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Data.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasData(
            new Category { Id = Guid.NewGuid(), Name = "Health" },
            new Category { Id = Guid.NewGuid(), Name = "Fitness" },
            new Category { Id = Guid.NewGuid(), Name = "Hobbies" },
            new Category { Id = Guid.NewGuid(), Name = "Work" },
            new Category { Id = Guid.NewGuid(), Name = "Study" },
            new Category { Id = Guid.NewGuid(), Name = "Personal" },
            new Category { Id = new Guid("00000000-0000-0000-0000-000000000001"), Name = "Default" }
            );
    }
}
