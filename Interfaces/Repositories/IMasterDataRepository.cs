using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories
{
   public interface IMasterDataRepository
    {
        Task<List<MasterData>> GetAllMasterDataWithParentCode(string parentCode);
    }
}
