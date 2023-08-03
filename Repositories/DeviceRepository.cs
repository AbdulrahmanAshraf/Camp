using Microsoft.EntityFrameworkCore;
using PlaystationProject.Dtos;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories.General
{
    public class DeviceRepository : BaseRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(PlayStationDbContext playStationDb) : base(playStationDb)
        {

        }

        public async Task<(List<Device>, int)> GetAllDevicesWithPagination(GridSearchDto paginationDto)
        {
            IQueryable<Device> devices = _playStationDbContext.Devices.Include(m => m.MasterDataCode).OrderByDescending(a => a.Create_Date);
            if (!string.IsNullOrEmpty(paginationDto.SearchName)) devices = devices.Where(a => a.Name.Contains(paginationDto.SearchName)).OrderByDescending(a => a.Create_Date);
            int length = devices.Count();
            if (paginationDto.PageNumber == -1) return (await devices.ToListAsync(), length);
            return (await devices.Skip((paginationDto.PageNumber - 1) * paginationDto.PageSize).Take(paginationDto.PageSize).Include(a => a.MasterDataCode).ToListAsync(), length);
        }

        public async Task<Device> GetDeviceById(Guid deviceId)
        {
            return await _playStationDbContext.Devices.Include(w => w.WorkingDevices).FirstOrDefaultAsync(d => d.Id == deviceId);
        }
    }
}
