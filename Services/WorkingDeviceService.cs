using AutoMapper;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Devices;
using PlaystationProject.Dtos.Orders;
using PlaystationProject.Dtos.WorkingDevices;
using PlaystationProject.Enums;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Interfaces.Services;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Services
{
    public class WorkingDeviceService : IWorkingDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IPeriodRepository _periodRepository;
        private readonly IWorkingDeviceRepository _workingDeviceRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMasterDataRepository _masterDataRepository;
        private readonly IMapper _mapper;
        private readonly IHistoryRepository _historyRepository;

        public WorkingDeviceService(IHistoryRepository historyRepository, IPeriodRepository periodRepository, IWorkingDeviceRepository workingDeviceRepository, IMapper mapper, IDeviceRepository deviceRepository, IUnitOfWork unitOfWork, IMasterDataRepository masterDataRepository)
        {
            _mapper = mapper;
            _deviceRepository = deviceRepository;
            _unitOfWork = unitOfWork;
            _masterDataRepository = masterDataRepository;
            _workingDeviceRepository = workingDeviceRepository;
            _periodRepository = periodRepository;
            _historyRepository = historyRepository;
        }

        public async Task<ServiceResponse<(List<GetAllWorkingDevicesDto>, int)>> GetAllWorkingDevicesAsync(GridSearchDto paginationDto, bool? IsOpen)
        {
            try
            {
                (List<WorkingDevice> workingDevices, int length) = await _workingDeviceRepository.GetAllWorkingDeviceList(paginationDto, IsOpen);
                if (workingDevices == null || length == 0) return new ServiceResponse<(List<GetAllWorkingDevicesDto>, int)> { Data = (new List<GetAllWorkingDevicesDto>(), 0), Success = false, Message = "لا يوجد بيانات" };
                List<GetAllWorkingDevicesDto> workingDevicesDto = workingDevices.Select(w => new GetAllWorkingDevicesDto
                {
                    Id = w.Id,
                    DeviceName = w.Device.Name,
                    OrderId = w.Order != null ? w.Order.Id.ToString() : null,
                    StartTime = w.Create_Date != null ? w.Create_Date.ToString("hh:mm tt") : "",
                    EndTime = w.Last_Modify_Date != null ? w.Last_Modify_Date.Value.ToString("hh:mm tt") : "",
                    Date = w.Create_Date != null ? w.Create_Date.Date.ToString("yyyy/MM/dd") : "",
                    IsWorking = w.Periods.Any(p => p.Status == WorkingDeviceStatus.WODES.ToString())

                }).ToList();
                return new ServiceResponse<(List<GetAllWorkingDevicesDto>, int)> { Data = (workingDevicesDto, length), Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<(List<GetAllWorkingDevicesDto>, int)> { Data = (new List<GetAllWorkingDevicesDto>(), 0), Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<bool>> RunDeviceAsync(RunDeviceDto runDeviceDto, string userFullName)
        {
            try
            {
                Device device = await _deviceRepository.GetDeviceById(runDeviceDto.DeviceId);
                if (device == null) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لا يوجد بيانات" };
                if (device.WorkingDevices.Any(w => !w.Is_Paid)) return new ServiceResponse<bool> { Data = false, Success = false, Message = "هذا الجهاز يعمل حاليا" };
                WorkingDevice workingDevice = new WorkingDevice()
                {
                    Device_Id = device.Id,
                    Is_Paid = false,
                    Total_Cost = 0
                };
                _workingDeviceRepository.Create(workingDevice);
                Period period = new Period()
                {
                    Working_Device_Id = workingDevice.Id,
                    Type = runDeviceDto.PeriodType,
                    Start_Time = DateTime.Now,
                    Status = WorkingDeviceStatus.WODES.ToString()
                };
                _periodRepository.Create(period);
                var historyDiscription = " لقد قام " + userFullName + " بتشغيل الجهاز " + device.Name;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                int result = await _unitOfWork.CommitAsync();
                if (result < 0) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم تتم العملية" };
                return new ServiceResponse<bool> { Data = true, Success = true, Message = "تمت العملية بنجاح" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<bool> { Data = false, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<bool>> CloseDeviceAsync(CloseDeviceDto closeDeviceDto, string userFullName)
        {
            try
            {
                WorkingDevice workingDevice = await _workingDeviceRepository.GetWorkingDeviceWithPeriods(closeDeviceDto.Id);
                if (workingDevice == null) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لا يوجد بيانات" };
                workingDevice.Is_Paid = true;
                workingDevice.Periods.Select(p => { p.Status = WorkingDeviceStatus.CLDES.ToString(); p.End_Time = DateTime.Now; return p; }).ToList();
                workingDevice.Total_Cost = ((decimal)workingDevice.Periods.Select(p => p.Type == PeriodType.SINGL.ToString() ? p.End_Time == null ?
                         Math.Round(workingDevice.Device.Single_Hour_Cost * (DateTime.Now - p.Start_Time).TotalHours)
                         : Math.Round(workingDevice.Device.Single_Hour_Cost * (p.End_Time.Value - p.Start_Time).TotalHours) : p.End_Time == null ?
                         Math.Round(workingDevice.Device.Multi_Hour_Cost * (DateTime.Now - p.Start_Time).TotalHours)
                         : Math.Round(workingDevice.Device.Multi_Hour_Cost * (p.End_Time.Value - p.Start_Time).TotalHours)).Sum()) - closeDeviceDto.Discount;
                workingDevice.Discount = closeDeviceDto.Discount;
                if (workingDevice.Order != null) workingDevice.Order.Is_Paid = true;
                var historyDiscription = " لقد قام " + userFullName + " بغلق الجهاز" + workingDevice.Device.Name;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                int result = await _unitOfWork.CommitAsync();
                if (result < 0) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم تتم العملية" };
                return new ServiceResponse<bool> { Data = true, Success = true, Message = "تمت العملية بنجاح" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<bool> { Data = false, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<GetWorkingDeviceDetailsDto>> GetWorkingDeviceDetailsToCloseAsync(Guid workingDeviceId)
        {
            try
            {
                WorkingDevice workingDevice = await _workingDeviceRepository.GetWorkingDeviceWithPeriods(workingDeviceId);
                if (workingDevice == null) return new ServiceResponse<GetWorkingDeviceDetailsDto> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                GetWorkingDeviceDetailsDto workingDeviceDetailsDto = new GetWorkingDeviceDetailsDto()
                {
                    Id = workingDevice.Id,
                    Name = workingDevice.Device.Name,
                    StartDate = workingDevice.Create_Date.ToString("yyyy/MM/dd hh:mm tt"),
                    EndDate = DateTime.Now.ToString("yyyy/MM/dd hh:mm tt"),
                    PlayStationTotalCost = workingDevice.Periods.Select(p => p.Type == PeriodType.SINGL.ToString() ? p.End_Time == null ?
                          Math.Round(workingDevice.Device.Single_Hour_Cost * (DateTime.Now - p.Start_Time).TotalHours)
                          : Math.Round(workingDevice.Device.Single_Hour_Cost * (p.End_Time.Value - p.Start_Time).TotalHours) : p.End_Time == null ?
                          Math.Round(workingDevice.Device.Multi_Hour_Cost * (DateTime.Now - p.Start_Time).TotalHours)
                          : Math.Round(workingDevice.Device.Multi_Hour_Cost * (p.End_Time.Value - p.Start_Time).TotalHours)).Sum(),
                    OrderTotalCost = workingDevice.Order != null ? workingDevice.Order.Total_Cost : 0
                };
                return new ServiceResponse<GetWorkingDeviceDetailsDto> { Data = workingDeviceDetailsDto, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<GetWorkingDeviceDetailsDto> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<GetWorkingDeviceDetailsDto>> GetWorkingDeviceDetailsAsync(Guid workingDeviceId)
        {
            try
            {
                WorkingDevice workingDevice = await _workingDeviceRepository.GetWorkingDeviceWithPeriods(workingDeviceId);
                if (workingDevice == null) return new ServiceResponse<GetWorkingDeviceDetailsDto> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                GetWorkingDeviceDetailsDto workingDeviceDetailsDto = new GetWorkingDeviceDetailsDto()
                {
                    Id = workingDevice.Id,
                    Name = workingDevice.Device.Name,
                    StartDate = workingDevice.Create_Date.ToString("yyyy/MM/dd hh:mm tt"),
                    EndDate = workingDevice.Is_Paid ? workingDevice.Last_Modify_Date.Value.ToString("yyyy/MM/dd hh:mm tt") : "",
                    OrderTotalCost = workingDevice.Order != null ? workingDevice.Order.Total_Cost : 0,
                    PlayStationTotalCost = workingDevice.Periods.Select(p => p.Type == PeriodType.SINGL.ToString() ? p.End_Time == null ?
                          Math.Round(workingDevice.Device.Single_Hour_Cost * (DateTime.Now - p.Start_Time).TotalHours)
                          : Math.Round(workingDevice.Device.Single_Hour_Cost * (p.End_Time.Value - p.Start_Time).TotalHours) : p.End_Time == null ?
                          Math.Round(workingDevice.Device.Multi_Hour_Cost * (DateTime.Now - p.Start_Time).TotalHours)
                          : Math.Round(workingDevice.Device.Multi_Hour_Cost * (p.End_Time.Value - p.Start_Time).TotalHours)).Sum(),
                    OrderDetails = workingDevice.Order != null ? workingDevice.Order.OrderDetails.Select(d => new OrderDetailsDto
                    {
                        Name = d.Product.Name,
                        Count = d.Quantity.ToString(),
                        Price = d.Product.Price.ToString(),
                        Total = (d.Quantity * d.Product.Price).ToString()
                    }).ToList() : new List<OrderDetailsDto>(),
                    Periods = workingDevice.Periods.Select(p => new WorkingDevicePeeriodsDto
                    {
                        Type = p.MasterDataCode.Category_Name,
                        TotalHours = p.End_Time == null ?
                                        (DateTime.Now - p.Start_Time).ToString().Split(":")[0] + ":" + (DateTime.Now - p.Start_Time).ToString().Split(":")[1]
                                        : (p.End_Time.Value - p.Start_Time).ToString().Split(":")[0] + ":" + (p.End_Time.Value - p.Start_Time).ToString().Split(":")[1],
                        Cost = p.Type == PeriodType.SINGL.ToString() ? p.End_Time == null ?
                            Math.Round((workingDevice.Device.Single_Hour_Cost * (DateTime.Now - p.Start_Time).TotalHours)).ToString()
                            : Math.Round((workingDevice.Device.Single_Hour_Cost * (p.End_Time.Value - p.Start_Time).TotalHours)).ToString() : p.End_Time == null ?
                            Math.Round((workingDevice.Device.Multi_Hour_Cost * (DateTime.Now - p.Start_Time).TotalHours)).ToString()
                            : Math.Round((workingDevice.Device.Multi_Hour_Cost * (p.End_Time.Value - p.Start_Time).TotalHours)).ToString()
                    }).ToList(),
                    //Discount = workingDevice.Discount != null ? workingDevice.Discount.Value.ToString() : "0"
                };
                return new ServiceResponse<GetWorkingDeviceDetailsDto> { Data = workingDeviceDetailsDto, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<GetWorkingDeviceDetailsDto> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<bool>> AddPeriodToRunningDeviceAsync(AddPeriodDto addPeriodDto, string userFullName)
        {
            try
            {
                WorkingDevice workingDevice = await _workingDeviceRepository.GetWorkingDeviceWithPeriods(addPeriodDto.WorkingDeviceId);
                if (workingDevice == null) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لا يوجد بيانات" };
                workingDevice.Periods.Where(p => p.Status == WorkingDeviceStatus.WODES.ToString())
                .Select(p => { p.Status = WorkingDeviceStatus.CLDES.ToString(); p.End_Time = DateTime.Now; return p; }).ToList();
                Period period = new Period()
                {
                    Working_Device_Id = workingDevice.Id,
                    Type = addPeriodDto.PeriodType,
                    Start_Time = DateTime.Now,
                    End_Time = null,
                    Status = WorkingDeviceStatus.WODES.ToString()
                };
                var historyDiscription = " لقد قام " + userFullName + " باضافة فترة للجهاز" + workingDevice.Device.Name;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                _periodRepository.Create(period);
                int result = await _unitOfWork.CommitAsync();
                if (result < 0) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم تتم العملية" };
                return new ServiceResponse<bool> { Data = true, Success = true, Message = "تمت العملية بنجاح" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<bool> { Data = false, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<List<DropDown>>> GetAllWorkingDevices()
        {
            try
            {
                var devices = await _workingDeviceRepository.GetAllWorkingDeviceWithoutOrder();
                if (devices == null || devices.Count == 0) return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                var devicesDto = _mapper.Map<List<DropDown>>(devices);
                return new ServiceResponse<List<DropDown>> { Data = devicesDto, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<List<DropDown>>> GetAllWorkingDevices(Guid? workingDeviceId)
        {
            try
            {
                var devices = await _workingDeviceRepository.GetAllWorkingDevice(workingDeviceId);
                if (devices == null || devices.Count == 0) return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                var devicesDto = _mapper.Map<List<DropDown>>(devices);
                return new ServiceResponse<List<DropDown>> { Data = devicesDto, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }

    }
}
