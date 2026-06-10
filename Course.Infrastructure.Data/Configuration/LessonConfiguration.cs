using Course.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.Infrastructure.Data.Configuration
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ModuleId).IsRequired();
            builder.Property(c => c.Title).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Slug).IsRequired().HasMaxLength(170);
            
            builder.HasOne(c => c.Module).WithMany(m => m.Lessons).HasForeignKey(c => c.ModuleId);
        }
    }
}