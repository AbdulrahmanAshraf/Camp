using Microsoft.EntityFrameworkCore;
using PlaystationProject.Dtos;
using PlaystationProject.Enums;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Models;
using PlaystationProject.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories
{
    public class WorkingDeviceRepository : BaseRepository<WorkingDevice>, IWorkingDeviceRepository
    {
        public WorkingDeviceRepository(PlayStationDbContext playStationDb) : base(playStationDb)
        {

        }

        public async Task<WorkingDevice> GetWorkingDeviceWithPeriods(Guid workingDeviceId)
        {
            return await _playStationDbContext.WorkingDevices.Include(d => d.Device)
                .Include(o => o.Order).ThenInclude(d => d.OrderDetails).ThenInclude(p => p.Product)
                .Include(p => p.Periods).ThenInclude(m => m.MasterDataCode).FirstOrDefaultAsync(w => w.Id == workingDeviceId);
        }

        public async Task<List<WorkingDevice>> GetAllWorkingDeviceWithoutOrder()
        {
            return await _playStationDbContext.WorkingDevices.Where(a => a.Periods.Any(a => a.Status == WorkingDeviceStatus.WODES.ToString()) && a.Order == null).Include(d => d.Device).ToListAsync();
        }

        public async Task<List<WorkingDevice>> GetAllWorkingDevice(Guid? workingDeviceId)
        {
            return await _playStationDbContext.WorkingDevices.Where(a => (a.Periods.Any(a => a.Status == WorkingDeviceStatus.WODES.ToString()) && a.Order == null) || a.Id == workingDeviceId.Value).Include(d => d.Device).ToListAsync();
        }

        public async Task<(List<WorkingDevice>, int length)> GetAllWorkingDeviceList(GridSearchDto paginationDto, bool? IsOpen)
        {
            IQueryable<WorkingDevice> workingDevices = _playStationDbContext.WorkingDevices.Include(p => p.Periods).OrderByDescending(a => a.Create_Date);
            if (!string.IsNullOrEmpty(paginationDto.SearchName)) workingDevices = workingDevices.Where(w => w.Device.Name.Contains(paginationDto.SearchName)).OrderByDescending(a => a.Create_Date);
            //if (IsOpen != null) workingDevices = workingDevices.Where(w => w.Periods.Any(p =>IsOpen.Value==true? p.Status == WorkingDeviceStatus.WODES.ToString(): p.Status == WorkingDeviceStatus.CLDES.ToString()));
            if (IsOpen != null) workingDevices = IsOpen.Value == true ?
                    workingDevices.Where(w => w.Periods.Any(p => p.Status == WorkingDeviceStatus.WODES.ToString())) : workingDevices.Where(w => w.Periods.All(p => p.Status == WorkingDeviceStatus.CLDES.ToString()));
            int length = workingDevices.Count();
            return (await workingDevices.Skip(0).Take(paginationDto.PageSize).Include(d => d.Device).Include(p => p.Periods).Include(a => a.Order).ToListAsync(), length);
        }

        public async Task<List<WorkingDevice>> GetTodayWorkingDevices()
        {
            return await _playStationDbContext.WorkingDevices.Where(w => w.Last_Modify_Date.Value.Date == DateTime.Now.Date && w.Is_Paid).ToListAsync();
        }
        public async Task<List<WorkingDevice>> GetAllOrdersWorkingDevicesForADatePeriod(DateTime? from, DateTime? to)
        {
            var workingDevices = _playStationDbContext.WorkingDevices.Where(a => a.Is_Paid);

            if (from.HasValue && to.HasValue)
                workingDevices = workingDevices.Where(a => a.Last_Modify_Date.Value.Date >= from.Value.Date && a.Last_Modify_Date.Value.Date <= to.Value.Date);
            else if (from.HasValue)
                workingDevices = workingDevices.Where(a => a.Last_Modify_Date.Value.Date >= from.Value.Date && a.Last_Modify_Date.Value.Date <= from.Value.Date.AddDays(30).Date);
            else if (to.HasValue)
                workingDevices = workingDevices.Where(a => a.Last_Modify_Date.Value.Date <= to.Value.Date && a.Last_Modify_Date.Value.Date >= to.Value.Date.AddDays(-30).Date);
            else
                workingDevices = workingDevices.Where(a => a.Last_Modify_Date.Value.Date >= DateTime.Now.Date.AddDays(-30).Date && a.Last_Modify_Date.Value.Date <= DateTime.Now.Date);
            return await workingDevices.ToListAsync();
        }
    }
}
