using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSchool.Domain.Entities;
using System.Text.RegularExpressions;

namespace OnlineSchool.Infrastructure.Persistance.Configurations
{
    internal class StudyGroupConfiguration : IEntityTypeConfiguration<StudyGroup>
    {
        public void Configure(EntityTypeBuilder<StudyGroup> builder)
        {
            builder.ToTable(nameof(StudyGroup));
            builder.HasKey(g => g.Id);

            builder
                .HasOne(ts => ts.TeacherSubject)
                .WithMany(s => s.StudyGroups)
                .HasForeignKey(ts => ts.TeacherSubjectId)
                .IsRequired();

            builder
                .Property(c => c.Name)
                .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
                .IsRequired();
        }
    }
}
