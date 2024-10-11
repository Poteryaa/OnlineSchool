using OnlineSchool.Domain.Common;

namespace OnlineSchool.Domain.Entities
{
    public class StudyGroup : AuditableEntity
    {
        public string Name { get; set; }

        public int TeacherSubjectId { get; set; }
        public TeacherSubject TeacherSubject { get; set; }

        public virtual IEnumerable<Student> Students { get; set; }

    }
}
