using DepartmentsWEB.db.Models;
using DepartmentsWEB.Models;

namespace DepartmentsWEB.Helpers
{
    public static class Mapping
    {
        public static Person ToPerson(this NewPersonViewModel newperson)
        {
            var person = new Person
            {
                LastName = newperson.LastName,
                FirstName = newperson.FirstName,
                DepartmentId = newperson.DepartmentId,
            };
            return person;
        }
    }
}