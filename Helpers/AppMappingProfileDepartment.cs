using AutoMapper;
using DepartmentsWEB.db.Models;
using DepartmentsWEB.Models;

namespace DepartmentsWEB.Helpers
{
    public class AppMappingProfileDepartment : Profile
    {
        public AppMappingProfileDepartment()
        {
            CreateMap<Department, DepartmentViewModel>();
        }
    }
}