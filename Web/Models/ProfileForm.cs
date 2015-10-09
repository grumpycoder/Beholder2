using AutoMapper;
using Domain.Models;
using Heroic.AutoMapper;

namespace Web.Models
{
    public class ProfileForm : IMapFrom<ApplicationUser>, IHaveCustomMappings
    {
        public string Username { get; set; }

        public string EmailAddress { get; set; }
        public string FullName { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<ApplicationUser, ProfileForm>()
                .ForMember(d => d.EmailAddress, opt => opt.MapFrom(s => s.Email));
//                .ForMember(d => d.Username, opt => opt.MapFrom(s => s.UserName))
                
        }
    }
}