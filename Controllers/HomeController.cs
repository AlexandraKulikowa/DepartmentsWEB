using AutoMapper;
using DepartmentsWEB.db.Interfaces;
using DepartmentsWEB.Helpers;
using DepartmentsWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentsWEB.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentsRepository departmentsRepository;
        private IPersonsRepository personsRepository;
        private readonly IMapper mapper;

        public HomeController(IDepartmentsRepository departmentsRepository, IPersonsRepository personsRepository, IMapper mapper)
        {
            this.departmentsRepository = departmentsRepository;
            this.personsRepository = personsRepository;
            this.mapper = mapper;
        }

        public IActionResult Index(int id = 1)
        {
            var departmentVM = new CreateVisual(departmentsRepository, mapper).ToCreateVisual(id);
            return View(departmentVM);
        }

        public IActionResult ChangeDepartment(int personId, int newDepartmentId)
        {
            personsRepository.ChangeDepartment(personId, newDepartmentId);
            return RedirectToAction("Index", "Home", new { id = newDepartmentId });
        }

        public IActionResult AddPerson()
        {
            NewPersonViewModel newPerson = new NewPersonViewModel();
            newPerson.Departments = new CreateVisual(departmentsRepository, mapper).ToDepartmentsVM();
            return View(newPerson);
        }

        [HttpPost]
        public IActionResult AddPerson(NewPersonViewModel newPerson)
        {
            if (ModelState.IsValid)
            {
                var person = newPerson.ToPerson();
                personsRepository.AddPerson(person);
                return RedirectToAction("Index", "Home", new { id = person.DepartmentId });
            }
            newPerson.Departments = new CreateVisual(departmentsRepository, mapper).ToDepartmentsVM();
            return View(newPerson);
        }
    }
}