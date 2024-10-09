using OnlineSchool.Domain.Common;

namespace OnlineSchool.Domain.Entities
{
    public class TeacherSubject : AuditableEntity
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
