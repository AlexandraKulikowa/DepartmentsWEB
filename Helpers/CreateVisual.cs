using AutoMapper;
using DepartmentsWEB.db.Interfaces;
using DepartmentsWEB.db.Models;
using DepartmentsWEB.Models;

namespace DepartmentsWEB.Helpers
{
    public class CreateVisual
    {
        private IDepartmentsRepository departmentsRepository;
        private readonly IMapper mapper;

        public CreateVisual(IDepartmentsRepository departmentsRepository, IMapper mapper)
        {
            this.departmentsRepository = departmentsRepository;
            this.mapper = mapper;
        }

        public DepartmentVisualViewModel ToCreateVisual(int id)
        {
            var departments = departmentsRepository.GetAll();
            var department = departmentsRepository.TryGetById(id);
            var people = department.People.ToList();

            var departmentsVM = mapper.Map<List<DepartmentViewModel>>(departments);
            var personsVM = mapper.Map<List<Person>, List<PersonViewModel>>(people);
            var departmentVM = mapper.Map<DepartmentViewModel>(department);

            departmentVM.People = personsVM;
            var departmentVisualVM = new DepartmentVisualViewModel()
            {
                Department = departmentVM,
                Departments = departmentsVM
            };

            return departmentVisualVM;
        }

        public List<DepartmentViewModel> ToDepartmentsVM()
        {
            var departments = departmentsRepository.GetAll();
            var departmentsVM = mapper.Map<List<DepartmentViewModel>>(departments);
            return departmentsVM;
        }
    }
}