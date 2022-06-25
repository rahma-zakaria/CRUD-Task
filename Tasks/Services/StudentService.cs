using Tasks.Models;

namespace Tasks.Services
{
    public class StudentService : IStudentService
    {
        private IRepository<Student> _reprositry;
        public StudentService(IRepository<Student> reprositry)
        {
            _reprositry = reprositry;
        }

        public void Delete(int id)
        {
            Student student = GetById(id);
            _reprositry.Remove(student);
            _reprositry.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            return _reprositry.GetAll();
        }

        public Student GetById(int id)
        {
            return _reprositry.Get(id);
        }

        public void Insert(Student student)
        {
            _reprositry.Insert(student);
            _reprositry.SaveChanges();
        }

        public void Update(Student student)
        {
            _reprositry.Update(student);
            _reprositry.SaveChanges();
        }
    }
}
