namespace DepartmentsWEB.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PersonViewModel> People { get; set; }
    }
}