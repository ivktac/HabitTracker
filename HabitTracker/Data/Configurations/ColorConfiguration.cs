using HabitTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Data.Configurations;

public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.ToTable("Colors");

        builder.HasData(
            new Color { Id = Guid.NewGuid(), Name = "Rosewater", Code = "#dc8a78" },
            new Color { Id = Guid.NewGuid(), Name = "Flamingo", Code = "#dd7878" },
            new Color { Id = Guid.NewGuid(), Name = "Pink", Code = "#ea76cb" },
            new Color { Id = Guid.NewGuid(), Name = "Mauve", Code = "#8839ef" },
            new Color { Id = Guid.NewGuid(), Name = "Red", Code = "#d20f39" },
            new Color { Id = Guid.NewGuid(), Name = "Maroon", Code = "#e64553" },
            new Color { Id = Guid.NewGuid(), Name = "Peach", Code = "#fe640b" },
            new Color { Id = Guid.NewGuid(), Name = "Yellow", Code = "#df8e1d" },
            new Color { Id = Guid.NewGuid(), Name = "Green", Code = "#40a02b" },
            new Color { Id = Guid.NewGuid(), Name = "Teal", Code = "#179299" },
            new Color { Id = Guid.NewGuid(), Name = "Sky", Code = "#04a5e5" },
            new Color { Id = Guid.NewGuid(), Name = "Sapphire", Code = "#209fb5" },
            new Color { Id = Guid.NewGuid(), Name = "Blue", Code = "#1e66f5" },
            new Color { Id = Guid.NewGuid(), Name = "Lavender", Code = "#7287fd" });
    }
}
