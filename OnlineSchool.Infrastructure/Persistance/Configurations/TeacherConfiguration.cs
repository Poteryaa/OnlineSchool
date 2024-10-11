using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Domain.Entities;

namespace OnlineSchool.Infrastructure.Persistance.Configurations
{
    internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable(nameof(Teacher));
            builder.HasKey(t => t.Id);

            builder
                .Property(c => c.FirstName)
                .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
                .IsRequired();

            builder
                .Property(c => c.LastName)
                .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
                .IsRequired();
        }
    }
}
