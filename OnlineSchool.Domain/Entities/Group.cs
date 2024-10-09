using OnlineSchool.Domain.Common;

namespace OnlineSchool.Domain.Entities
{
    public class Group : AuditableEntity
    {
        public string Name { get; set; }

        public int TeacherSubjectId { get; set; }
        public TeacherSubject TeacherSubject { get; set; }
    }
}
