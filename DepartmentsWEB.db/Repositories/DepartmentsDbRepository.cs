using DepartmentsWEB.db.Interfaces;
using DepartmentsWEB.db.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentsWEB.db.Repositories
{
    public class DepartmentsDbRepository : IDepartmentsRepository
    {
        private readonly DatabaseContext databaseContext;
        public DepartmentsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<Department> GetAll()
        {
            var departments = databaseContext.Departments
                .Include(x => x.People)
                .ToList();
            return departments;
        }

        public Department TryGetById(int id)
        {
            return databaseContext.Departments
            .Include(x => x.People)
            .FirstOrDefault(department => department.Id == id);
        }
    }
}