using DepartmentsWEB.db.Interfaces;
using DepartmentsWEB.db.Models;

namespace DepartmentsWEB.db.Repositories
{
    public class PersonsDbRepository : IPersonsRepository
    {
        private readonly DatabaseContext databaseContext;
        public PersonsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<Person> GetAll(int id)
        {
            var department = databaseContext.Departments.Find(id);
            var persons = department.People.ToList();
            return persons;
        }

        public void ChangeDepartment(int personId, int newDepartmentId)
        {
            var person = databaseContext.Persons.Find(personId);
            person.DepartmentId = newDepartmentId;
            databaseContext.Update(person);
            databaseContext.SaveChanges();
        }

        public void AddPerson(Person person)
        {
            databaseContext.Persons.Add(person);
            databaseContext.SaveChanges();
        }
    }
}