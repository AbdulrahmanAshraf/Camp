using AutoMapper;

using PlaystationProject.Dtos;
using PlaystationProject.Dtos.History;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Services
{
    public class HistoryService: IHistoryService
    {
        private readonly IHistoryRepository _historyRepository;
        private readonly IMapper _mapper;

        public HistoryService(IHistoryRepository historyRepository, IMapper mapper)
        {
            _historyRepository = historyRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<(List<GetHistoryDto>, int)>> GetAllHistories(GridSearchDto gridSearch)
        {
            try
            {
                (var histories, int length) =await _historyRepository.GetAllHistories(gridSearch);
                if (histories == null || length == 0) return new ServiceResponse<(List<GetHistoryDto>, int)> { Data = (new List<GetHistoryDto>(), 0), Success = false, Message = "لا يوجد بيانات" };
                var historiesDtos = _mapper.Map<List<GetHistoryDto>>(histories);
                return new ServiceResponse<(List<GetHistoryDto>, int)> { Data = (historiesDtos, length), Success = true };

            }
            catch (Exception ex)
            {
                return new ServiceResponse<(List<GetHistoryDto>, int)> { Data = (new List<GetHistoryDto>(), 0), Success = false, Message = "حدثت مشكلة ما" };
            }
        }
    }
}
