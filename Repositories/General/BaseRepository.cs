using Microsoft.EntityFrameworkCore;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories.General
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly PlayStationDbContext _playStationDbContext;
        public BaseRepository(PlayStationDbContext playStationDbContext)
        {
            _playStationDbContext = playStationDbContext;
        }
        public virtual async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
                return await _playStationDbContext.Set<T>().ToListAsync();
            else
                return await _playStationDbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
                return _playStationDbContext.Set<T>().ToList();
            else
                return _playStationDbContext.Set<T>().Where(predicate).ToList();
        }

        public Task<int> Count(Expression<Func<T, bool>> predicate = null) =>
                        predicate == null
                ? _playStationDbContext.Set<T>().CountAsync()
                : _playStationDbContext.Set<T>().Where(predicate).CountAsync();
        public virtual T FindByID(Guid Id)
        {
            return _playStationDbContext.Set<T>().FirstOrDefault(z => z.Id == Id);

        }
        public virtual void Create(T obj)
        {
            _playStationDbContext.Attach(obj);
            _playStationDbContext.Entry(obj).State = EntityState.Added;
        }
        public virtual async Task CreateRangeAsync(IEnumerable<T> objList)
        {
            await _playStationDbContext.AddRangeAsync(objList);
        }
        public virtual void Delete(T obj)
        {
            _playStationDbContext.Set<T>().Remove(obj);
        }

    }
}
