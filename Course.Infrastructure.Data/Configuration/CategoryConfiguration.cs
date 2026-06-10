using Course.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.Infrastructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Slug).IsRequired();
            builder.Property(c => c.Description).IsRequired().HasMaxLength(240);
            builder.Property(c => c.IsActive).IsRequired();
            
            builder.HasIndex(c => c.Name).IsUnique();
            builder.HasIndex(c => c.Slug).IsUnique();
        }
    }
}