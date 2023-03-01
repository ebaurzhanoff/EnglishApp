using Domain.LessonBoundaryModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class LessonModelConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Title).HasMaxLength(256).IsRequired();
        builder.Property(x => x.SortOrder);
        builder.Property(x => x.Title).HasMaxLength(1024).IsRequired(false);

        builder.HasIndex(x => new { x.GroupToken, x.SortOrder});
    }
}

public class UnitModelConfiguration : IEntityTypeConfiguration<Unit>
{
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Title).HasMaxLength(256).IsRequired();
        builder.Property(x => x.SortOrder);

        builder.OwnsOne(x => x.Task);
        builder.OwnsMany(x => x.Sources);

        builder.HasOne(u => u.Lesson).WithMany(l => l.Units).HasForeignKey(u => u.LessonId);
    }
}