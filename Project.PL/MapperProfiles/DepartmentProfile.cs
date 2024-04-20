using AutoMapper;
using Project.DAL.Models;
using Project.PL.ViewModels;

namespace Project.PL.MapperProfiles
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentViewModel,Department>().ReverseMap();
        }
    }
}
