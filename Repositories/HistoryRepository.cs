using Microsoft.EntityFrameworkCore;
using PlaystationProject.Dtos;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Models;
using PlaystationProject.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories
{
    public class HistoryRepository:BaseRepository<Historie>, IHistoryRepository
    {
        public HistoryRepository(PlayStationDbContext playStationDbContext):base(playStationDbContext)
        {

        }
        public async Task<(List<Historie>, int)> GetAllHistories(GridSearchDto gridSearch)
        {
            var histories = _playStationDbContext.Histories.OrderByDescending(a=>a.Create_Date);
            if (!string.IsNullOrEmpty(gridSearch.SearchName)) histories = histories.Where(a => a.User.Full_Name.Contains(gridSearch.SearchName)).OrderByDescending(a => a.Create_Date);
            if(gridSearch.From.HasValue) histories = histories.Where(a => a.Create_Date.Date>=gridSearch.From.Value.Date).OrderByDescending(a => a.Create_Date);
            if (gridSearch.To.HasValue) histories = histories.Where(a => a.Create_Date.Date <= gridSearch.To.Value.Date).OrderByDescending(a => a.Create_Date);
            int length = histories.Count();
            return (await histories.Skip((gridSearch.PageNumber - 1) * gridSearch.PageSize).Take(gridSearch.PageSize).Include(a => a.User).ToListAsync(), length);
        }
    }
}
