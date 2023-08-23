using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentsWEB.db.Models
{
    public partial class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int DepartmentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual Department Department { get; set; }
    }
}