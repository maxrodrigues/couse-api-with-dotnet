using Course.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.Infrastructure.Data.Configuration
{
    public class ModuleConfiguration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CourseId).IsRequired();
            builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
            
            builder.HasOne(c => c.Course).WithMany(c => c.Modules).HasForeignKey(c => c.CourseId);
        }
    }
}