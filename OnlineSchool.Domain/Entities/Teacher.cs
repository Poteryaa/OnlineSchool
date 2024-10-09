using OnlineSchool.Domain.Common;

namespace OnlineSchool.Domain.Entities
{
    public class Teacher : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
