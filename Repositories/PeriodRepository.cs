using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Models;
using PlaystationProject.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories
{
    public class PeriodRepository : BaseRepository<Period>, IPeriodRepository
    {
        public PeriodRepository(PlayStationDbContext playStationDb) : base(playStationDb)
        {

        }
    }
}
