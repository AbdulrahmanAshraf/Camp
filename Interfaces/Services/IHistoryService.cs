using PlaystationProject.Dtos;
using PlaystationProject.Dtos.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Services
{
   public interface IHistoryService
    {
        Task<ServiceResponse<(List<GetHistoryDto>, int)>> GetAllHistories(GridSearchDto gridSearch);
    }
}
