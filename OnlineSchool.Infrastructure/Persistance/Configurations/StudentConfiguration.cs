using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Domain.Entities;

namespace OnlineSchool.Infrastructure.Persistance.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(nameof(Student));
            builder.HasKey(x => x.Id);

            builder
                .HasOne(g => g.Group)
                .WithMany(s => s.Students)
                .HasForeignKey(g => g.GroupId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder
                .HasOne(ts => ts.TeacherSubject)
                .WithMany(s => s.Students)
                .HasForeignKey(ts => ts.TeacherSubjectId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

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
