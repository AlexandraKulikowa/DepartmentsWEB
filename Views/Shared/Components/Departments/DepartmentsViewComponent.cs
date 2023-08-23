using AutoMapper;
using DepartmentsWEB.db.Interfaces;
using DepartmentsWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentsWEB.Views.Shared.Components.Departments
{
    public class DepartmentsViewComponent : ViewComponent
    {
        private readonly IDepartmentsRepository departmentsRepository;
        private readonly IMapper mapper;
        public DepartmentsViewComponent(IDepartmentsRepository departmentsRepository, IMapper mapper)
        {
            this.departmentsRepository = departmentsRepository;
            this.mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var departmentsDb = departmentsRepository.GetAll();
            var departmentsVM = mapper.Map<List<DepartmentViewModel>>(departmentsDb);

            return View("Departments", departmentsVM);
        }
    }
}