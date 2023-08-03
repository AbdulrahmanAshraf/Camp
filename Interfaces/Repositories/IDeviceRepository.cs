using PlaystationProject.Dtos;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories
{
    public interface IDeviceRepository : IBaseRepository<Device>
    {
        Task<(List<Device>, int)> GetAllDevicesWithPagination(GridSearchDto paginationDto);
        Task<Device> GetDeviceById(Guid deviceId);
    }
}
