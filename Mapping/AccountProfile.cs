using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Account;
using PlaystationProject.Models;
using PlaystationProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Mapping
{
    public class AccountProfile : MappingProfileBase
    {
        public AccountProfile()
        {
            CreateMap<TokenModel, TokenDto>()
                 .ForMember(dest => dest.CurrentUser, opt => opt.MapFrom(a=>a.CurrentUser))
              .ReverseMap();
            CreateMap<ApplicationUser, UserDto>()
                .ForMember(dest => dest.UserType, opt => opt.MapFrom(a => a.User_Type_Code))
             .ReverseMap();

        }
    }
}
