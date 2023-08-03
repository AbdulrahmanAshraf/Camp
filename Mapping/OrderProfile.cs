using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Orders;
using PlaystationProject.Models;
using PlaystationProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Mapping
{
    public class OrderProfile : MappingProfileBase
    {
        public OrderProfile()
        {
            CreateMap<Order, AddEditOrderDto>()
                
             .ForMember(dest => dest.Id, opt => opt.Ignore())
             .ForMember(dest => dest.SelectedProduct, opt => opt.Ignore())
             .ForMember(a => a.Products, x => x.MapFrom(a => a.OrderDetails))
              .ReverseMap();

            CreateMap<OrderDetail, AddProductToOrderDto>()
           .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Cost, opt => opt.Ignore())
              .ForMember(dest => dest.ProductName, opt => opt.Ignore())
            .ReverseMap()
             .ForMember(dest => dest.Product, opt => opt.Ignore())
            ;

            CreateMap<WorkingDevice, DropDown>()
              .ForMember(a => a.Id, x => x.MapFrom(a => a.Id))
                     .ForMember(a => a.Name, x => x.MapFrom(a => a.Device.Name))
                      .ForMember(a => a.Code, x => x.Ignore())
         .ReverseMap();
            CreateMap<Order, GetOrderDto>()
           .ForMember(a => a.Products, x => x.MapFrom(a => a.OrderDetails))
           .ForMember(a => a.OrderId, x => x.MapFrom(a => a.Order_Id.ToString()))
           .ForMember(a => a.Date, x => x.MapFrom(a => a.Create_Date.ToString("yyyy/MM/dd hh:mm tt")))
            .ForMember(a => a.DeviceName, x => x.MapFrom(a => a.WorkingDevice!=null?a.WorkingDevice.Device.Name:null))
            .ReverseMap();
            CreateMap<OrderDetail, GetOrderDetailDto>()
        .ForMember(a => a.ProductName, x => x.MapFrom(a => a.Product.Name))
         .ReverseMap();


        }
    }
}
