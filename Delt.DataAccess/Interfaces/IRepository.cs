﻿using System.Linq.Expressions;

namespace Delt.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(int take = 0);
        Task<IEnumerable<T>> GetByFilter(Expression<Func<T, bool>> predicate);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task Add(T entity);
        Task Remove(T entity);
    }
}
