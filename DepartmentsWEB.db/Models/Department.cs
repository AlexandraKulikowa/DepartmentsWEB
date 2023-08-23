namespace DepartmentsWEB.db.Models
{
    public partial class Department
    {
        public Department()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Person> People { get; set; }
    }
}