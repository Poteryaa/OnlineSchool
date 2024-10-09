using OnlineSchool.Domain.Common;

namespace OnlineSchool.Domain.Entities
{
    public class Subject : AuditableEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
