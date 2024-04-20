using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Project.PL.ViewModels;

namespace Project.PL.MapperProfiles
{
    public class RoleProfile:Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleViewModel,IdentityRole>()
                .ForMember(a=>a.Name,R=>R.MapFrom(s=>s.RoleName))
                .ReverseMap();
        }
    }
}
