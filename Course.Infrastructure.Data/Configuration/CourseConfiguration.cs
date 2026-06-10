using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.Infrastructure.Data.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Domain.Entities.Course>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CategoryId).IsRequired();
            builder.Property(c => c.UserId).IsRequired();
            builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Slug).IsRequired().HasMaxLength(120);
            builder.Property(c => c.Description).HasMaxLength(500);
            
            builder.HasOne(c => c.Category)
                .WithMany(c => c.Courses)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder.HasOne(c => c.User)
                .WithMany(c => c.Courses)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}