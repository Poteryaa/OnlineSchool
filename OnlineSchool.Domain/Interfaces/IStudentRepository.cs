using OnlineSchool.Domain.Entities;

namespace OnlineSchool.Domain.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetStudentBySubject(int id);
        List<Student> GetStudentByGroup(int id);
        List<Student> GetStudentByTeacher(int id);
    }
}
