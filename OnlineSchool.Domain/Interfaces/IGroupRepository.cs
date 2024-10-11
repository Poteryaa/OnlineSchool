using System.Text.RegularExpressions;

namespace OnlineSchool.Domain.Interfaces
{
    public interface IGroupRepository
    {
        List<Group> GetGroupsBySubject(int id);
    }
}
