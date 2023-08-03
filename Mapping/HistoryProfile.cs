using PlaystationProject.Dtos.History;
using PlaystationProject.Models;
using PlaystationProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Mapping
{
    public class HistoryProfile : MappingProfileBase
    {
        public HistoryProfile()
        {

            CreateMap<Historie, GetHistoryDto>()

               .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Create_Date.ToString("yyyy/MM/dd hh:mm tt")))
               .ForMember(a => a.UserFullName, x => x.MapFrom(a => a.User.Full_Name))
                .ReverseMap();
        }
    }
}
