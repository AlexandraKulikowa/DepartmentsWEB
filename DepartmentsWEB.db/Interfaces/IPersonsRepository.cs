using DepartmentsWEB.db.Models;

namespace DepartmentsWEB.db.Interfaces
{
    public interface IPersonsRepository
    {
        List<Person> GetAll(int id);
        void ChangeDepartment(int personId, int newDepartmentId);
        void AddPerson(Person person);
    }
}