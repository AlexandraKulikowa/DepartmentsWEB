using AutoMapper;
using DepartmentsWEB.db.Models;
using DepartmentsWEB.Models;

namespace DepartmentsWEB.Helpers
{
    public class AppMappingProfilePerson : Profile
    {
        public AppMappingProfilePerson()
        {
            CreateMap<Person, PersonViewModel>().ReverseMap();
        }
    }
}
