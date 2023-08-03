using AutoMapper;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Devices;
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
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMasterDataRepository _masterDataRepository;
        private readonly IMapper _mapper;
        private readonly IHistoryRepository _historyRepository;

        public DeviceService(IHistoryRepository historyRepository,IMapper mapper, IDeviceRepository deviceRepository, IUnitOfWork unitOfWork, IMasterDataRepository masterDataRepository)
        {
            _mapper = mapper;
            _deviceRepository = deviceRepository;
            _unitOfWork = unitOfWork;
            _masterDataRepository = masterDataRepository;
            _historyRepository = historyRepository;

        }

        public async Task<ServiceResponse<(List<GetAllDevicesDto>, int)>> GetAllDevicesAsync(GridSearchDto paginationDto)
        {
            try
            {
                (List<Device> devices, int length) = await _deviceRepository.GetAllDevicesWithPagination(paginationDto);
                if (devices == null || length == 0) return new ServiceResponse<(List<GetAllDevicesDto>, int)> { Data = (new List<GetAllDevicesDto>(), 0), Success = false, Message = "لا يوجد بيانات" };
                List<GetAllDevicesDto> devicesDto = devices.Select(d => new GetAllDevicesDto
                {
                    Id = d.Id,
                    Name = d.Name,
                    Type = d.MasterDataCode.Category_Name,
                    SingleHourCost = d.Single_Hour_Cost,
                    MultiHourCost = d.Multi_Hour_Cost,
                    LastModifiedDate = d.Last_Modify_Date != null ? d.Last_Modify_Date.Value.ToString("yyyy/MM/dd hh:mm tt") : ""
                }).ToList();
                return new ServiceResponse<(List<GetAllDevicesDto>, int)> { Data = (devicesDto, length), Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<(List<GetAllDevicesDto>, int)> { Data = (new List<GetAllDevicesDto>(), 0), Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<List<DropDown>>> GetDevicesDropDownAsync()
        {
            try
            {
                List<Device> devices = await _deviceRepository.GetAllAsync();
                if (devices == null) return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                List<DropDown> devicesDto = devices.Select(d => new DropDown
                {
                    Id = d.Id,
                    Name = d.Name
                }).ToList();
                return new ServiceResponse<List<DropDown>> { Data = devicesDto, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<EditDeviceDto>> GetDeviceByIdAsync(Guid deviceId)
        {
            try
            {
                Device device = await _deviceRepository.GetDeviceById(deviceId);
                if (device == null) return new ServiceResponse<EditDeviceDto> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                EditDeviceDto deviceDto = new EditDeviceDto()
                {
                    Id = device.Id.ToString(),
                    Name = device.Name,
                    Type = device.Type,
                    SingleHourCost = device.Single_Hour_Cost,
                    MultiHourCost = device.Multi_Hour_Cost
                };
                return new ServiceResponse<EditDeviceDto> { Data = deviceDto, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<EditDeviceDto> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<bool>> AddDeviceAsync(AddDeviceDto addDeviceDto, string userFullName)
        {
            try
            {
                Device device = new Device()
                {
                    Name = addDeviceDto.Name,
                    Type = addDeviceDto.Type,
                    Single_Hour_Cost = addDeviceDto.SingleHourCost,
                    Multi_Hour_Cost = addDeviceDto.MultiHourCost,
                };
                _deviceRepository.Create(device);
                var historyDiscription = " لقد قام " + userFullName + " باضافة الجهاز" + device.Name;
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

        public async Task<ServiceResponse<bool>> EditDeviceAsync(EditDeviceDto editDeviceDto, string userFullName)
        {
            try
            {
                Device device = _deviceRepository.FindByID(Guid.Parse(editDeviceDto.Id));
                if (device == null) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لا يوجد بيانات" };
                _mapper.Map<EditDeviceDto, Device>(editDeviceDto, device);
                var historyDiscription = " لقد قام " + userFullName + " بتعديل الجهاز" + device.Name;
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

        public async Task<ServiceResponse<List<DropDown>>> GetAllDeviceTypesAsync()
        {
            try
            {
                List<MasterData> types = await _masterDataRepository.GetAllMasterDataWithParentCode(DeviceTypeCode.DTPCD.ToString());
                if (types == null || types.Count == 0) return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                List<DropDown> typesDtos = types.Select(t => new DropDown { Name = t.Category_Name, Code = t.Code }).ToList();
                return new ServiceResponse<List<DropDown>> { Data = typesDtos, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<bool>> DeleteDeviceAsync(Guid deviceId, string userFullName)
        {
            try
            {
                Device device = await _deviceRepository.GetDeviceById(deviceId);
                if (device == null) return new ServiceResponse<bool> { Data = false, Success = false, Message = "العنصر غير موجود للحذف" };
                _deviceRepository.Delete(device);
                var historyDiscription = " لقد قام " + userFullName + " بحذف الجهاز" + device.Name;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                int result = await _unitOfWork.CommitAsync();
                if (result < 0) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم يتم حذف العنصر لارتباطة بعناصر أخري" };
                return new ServiceResponse<bool> { Data = true, Success = true, Message = "تمت العملية بنجاح" };
            }
            catch (Exception)
            {
                return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم يتم حذف العنصر لارتباطة بعناصر أخري" };
            }
        }
    }
}
