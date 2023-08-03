using PlaystationProject.Dtos;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories
{
    public interface IWorkingDeviceRepository : IBaseRepository<WorkingDevice>
    {
        Task<WorkingDevice> GetWorkingDeviceWithPeriods(Guid workingDeviceId);
        Task<List<WorkingDevice>> GetAllWorkingDeviceWithoutOrder();
        Task<List<WorkingDevice>> GetTodayWorkingDevices();
        Task<(List<WorkingDevice>, int length)> GetAllWorkingDeviceList(GridSearchDto paginationDto, bool? IsOpen);
        Task<List<WorkingDevice>> GetAllWorkingDevice(Guid? workingDeviceId);
        Task<List<WorkingDevice>> GetAllOrdersWorkingDevicesForADatePeriod(DateTime? from, DateTime? to);
    }
}
