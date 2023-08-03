using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Products;
using PlaystationProject.Models;
using PlaystationProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Mapping
{
    public class ProductsProfile : MappingProfileBase
    {
        public ProductsProfile()
        {

            CreateMap<Product, GetProductDto>()

               .ForMember(dest => dest.LastModifiedDate, opt => opt.MapFrom(src => src.Last_Modify_Date != null ? src.Last_Modify_Date.Value.ToString("yyyy/MM/dd hh:mm tt") : ""))
               .ForMember(a => a.Category, x => x.MapFrom(a => a.MasterDataCode.Category_Name))
                .ReverseMap();
            CreateMap<MasterData, DropDown>()

                          .ForMember(a => a.Name, x => x.MapFrom(a => a.Category_Name))
              .ReverseMap();
            CreateMap<Product, AddEditProductDto>()

                        .ForMember(a => a.Id, x => x.Ignore())
            .ReverseMap();
            CreateMap<Product, GetProductByCategoryDto>()
                  .ForMember(a => a.Id, x => x.MapFrom(a => a.Id))
                         .ForMember(a => a.Name, x => x.MapFrom(a => a.Name))
                          .ForMember(a => a.Cost, x => x.MapFrom(a=>a.Price))
             .ReverseMap();

        }
    }
}
