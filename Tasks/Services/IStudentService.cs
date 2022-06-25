using Tasks.Models;

namespace Tasks.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void Insert(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
