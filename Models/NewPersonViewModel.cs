using System.ComponentModel.DataAnnotations;

namespace DepartmentsWEB.Models
{
    public class NewPersonViewModel
    {
        public List<DepartmentViewModel> Departments { get; set; }

        [Required(ErrorMessage = "Укажите фамилию! Это обязательное поле.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Укажите имя! Это обязательное поле.")]
        public string FirstName { get; set; } = string.Empty;

        public int DepartmentId { get; set; } = 0;

        public NewPersonViewModel()
        {
            Departments = new List<DepartmentViewModel>();
        }
    }
}