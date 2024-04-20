using AutoMapper;
using Project.DAL.Models;
using Project.PL.ViewModels;

namespace Project.PL.MapperProfiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}
