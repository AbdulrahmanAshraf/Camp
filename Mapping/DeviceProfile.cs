using PlaystationProject.Dtos.Devices;
using PlaystationProject.Models;
using PlaystationProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Mapping
{
    public class DeviceProfile : MappingProfileBase
    {
        public DeviceProfile()
        {
            CreateMap<Device, EditDeviceDto>().ReverseMap();
        }
    }
}
