using PlaystationProject.Dtos;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories
{
   public interface IHistoryRepository : IBaseRepository<Historie>
    {
        Task<(List<Historie>, int)> GetAllHistories(GridSearchDto gridSearch);
    }
}
