using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories.General
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly PlayStationDbContext _playStationDbContext;
        public UnitOfWork(PlayStationDbContext playStationDbContext)
        {
            _playStationDbContext = playStationDbContext;
        }

        public async Task<int> CommitAsync()
        {
            return await _playStationDbContext.SaveChangesAsync();
        }

    }
}
