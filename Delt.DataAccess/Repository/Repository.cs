﻿using Delt.DataAccess.Data;
using Delt.DataAccess.Interfaces;
using Delt.Utility.Checkers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Delt.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public virtual async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual async Task Remove(T entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Remove(entity);
            });
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(int take = 0)
        {
            if (take == 0)
                return await _dbSet.ToListAsync();
            //if (filter.IsNull())
            //    return await _dbSet.ToListAsync();
            return await _dbSet.Take(take).ToListAsync();
        }

        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = _dbSet;
            query = query.Where(filter);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
