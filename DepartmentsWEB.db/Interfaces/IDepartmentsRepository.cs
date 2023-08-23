using DepartmentsWEB.db.Models;

namespace DepartmentsWEB.db.Interfaces
{
    public interface IDepartmentsRepository
    {
        List<Department> GetAll();
        Department TryGetById(int id);
    }
}