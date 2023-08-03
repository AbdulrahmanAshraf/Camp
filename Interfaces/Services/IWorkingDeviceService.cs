using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Devices;
using PlaystationProject.Dtos.WorkingDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Services
{
    public interface IWorkingDeviceService
    {
        Task<ServiceResponse<bool>> RunDeviceAsync(RunDeviceDto runDeviceDto, string userFullName);
        Task<ServiceResponse<List<DropDown>>> GetAllWorkingDevices();
        Task<ServiceResponse<bool>> AddPeriodToRunningDeviceAsync(AddPeriodDto addPeriodDto, string userFullName);
        Task<ServiceResponse<(List<GetAllWorkingDevicesDto>, int)>> GetAllWorkingDevicesAsync(GridSearchDto paginationDto, bool? IsOpen);
        Task<ServiceResponse<bool>> CloseDeviceAsync(CloseDeviceDto closeDeviceDto, string userFullName);
        Task<ServiceResponse<GetWorkingDeviceDetailsDto>> GetWorkingDeviceDetailsToCloseAsync(Guid workingDeviceId);
        Task<ServiceResponse<GetWorkingDeviceDetailsDto>> GetWorkingDeviceDetailsAsync(Guid workingDeviceId);
        Task<ServiceResponse<List<DropDown>>> GetAllWorkingDevices(Guid? workingDeviceId);
    }
}
