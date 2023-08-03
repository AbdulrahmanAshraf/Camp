using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Services
{
    public interface IDeviceService
    {
        Task<ServiceResponse<(List<GetAllDevicesDto>, int)>> GetAllDevicesAsync(GridSearchDto paginationDto);
        Task<ServiceResponse<EditDeviceDto>> GetDeviceByIdAsync(Guid deviceId);
        Task<ServiceResponse<bool>> AddDeviceAsync(AddDeviceDto addDeviceDto, string userFullName);
        Task<ServiceResponse<bool>> EditDeviceAsync(EditDeviceDto editDeviceDto, string userFullName);
        Task<ServiceResponse<bool>> DeleteDeviceAsync(Guid deviceId, string userFullName);
        Task<ServiceResponse<List<DropDown>>> GetAllDeviceTypesAsync();
        Task<ServiceResponse<List<DropDown>>> GetDevicesDropDownAsync();
    }
}
