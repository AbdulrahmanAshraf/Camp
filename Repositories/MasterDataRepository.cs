using Microsoft.EntityFrameworkCore;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Models;
using PlaystationProject.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories
{
    public class MasterDataRepository:IMasterDataRepository
    {
        private readonly PlayStationDbContext _PlayStationDbContext;
        public MasterDataRepository(PlayStationDbContext playStationDbContext)
        {
            _PlayStationDbContext = playStationDbContext;
        }
        public async Task<List<MasterData>> GetAllMasterDataWithParentCode(string parentCode)
        {
            return await _PlayStationDbContext.MasterData.Where(a => a.MasterData_Parent.Code == parentCode).ToListAsync();
        }
    }
}
