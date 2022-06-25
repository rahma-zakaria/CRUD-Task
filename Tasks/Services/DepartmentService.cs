using Tasks.Models;

namespace Tasks.Services
{
    public class DepartmentService : IDepartmentService
    {
        private IRepository<Department> _reprositry;
        public DepartmentService(IRepository<Department> reprositry)
        {
            _reprositry = reprositry;
        }

        public void Delete(int id)
        {
            Department department = GetById(id);
            _reprositry.Remove(department);
            _reprositry.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _reprositry.GetAll();
        }

        public Department GetById(int id)
        {
            return _reprositry.Get(id);
        }

        public void Insert(Department department)
        {
            _reprositry.Insert(department);
            _reprositry.SaveChanges();
        }

        public void Update(Department department)
        {
            _reprositry.Update(department);
            _reprositry.SaveChanges();
        }
    }
}
