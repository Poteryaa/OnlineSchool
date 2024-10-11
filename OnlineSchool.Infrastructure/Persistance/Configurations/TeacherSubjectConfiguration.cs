using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Domain.Entities;

namespace OnlineSchool.Infrastructure.Persistance.Configurations
{
    internal class TeacherSubjectConfiguration : IEntityTypeConfiguration<TeacherSubject>
    {
        public void Configure(EntityTypeBuilder<TeacherSubject> builder)
        {
            builder.ToTable(nameof(TeacherSubject));
            builder.HasKey(t => t.Id);

            builder
                .HasOne(s => s.Subject)
                .WithMany(ts => ts.TeacherSubjects)
                .HasForeignKey(s => s.SubjectId);

            builder
                .HasOne(t => t.Teacher)
                .WithMany(ts => ts.TeacherSubjects)
                .HasForeignKey(t => t.TeacherId);
        }
    }
}
