using Tasks.Models;

namespace Tasks.Services
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        void Insert(Department department);
        void Update(Department department);
        void Delete(int id);
    }
}
