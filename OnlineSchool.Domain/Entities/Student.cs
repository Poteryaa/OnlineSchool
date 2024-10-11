using OnlineSchool.Domain.Common;

namespace OnlineSchool.Domain.Entities
{
    public class Student : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int TeacherSubjectId { get; set; }
        public TeacherSubject TeacherSubject { get; set; }

        public int GroupId { get; set; }
        public StudyGroup Group { get; set; }
    }
}
