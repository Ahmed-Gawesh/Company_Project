using AutoMapper;
using Project.DAL.Models;
using Project.PL.ViewModels;

namespace Project.PL.Profiles
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeViewModel,Employee>().ReverseMap();
        }

    }
}
