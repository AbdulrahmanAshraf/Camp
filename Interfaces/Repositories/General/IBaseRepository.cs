﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories.General
{
    public interface IBaseRepository<T>
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);
        List<T> GetAll(Expression<Func<T, bool>> predicate = null);
        Task<int> Count(Expression<Func<T, bool>> predicate = null);
        T FindByID(Guid Id);
        void Create(T obj);
        Task CreateRangeAsync(IEnumerable<T> objList);
        void Delete(T obj);
    }
}
