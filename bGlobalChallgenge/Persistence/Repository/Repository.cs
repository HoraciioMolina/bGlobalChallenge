using bGlobalChallgenge.Domain.Repository;
using bGlobalChallgenge.Models.Entities;
using bGlobalChallgenge.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Persistence.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
           bool enabledTraking = true, int page = 0, int offset = 0)
        {

            IQueryable<T> query = _context.Set<T>();

            if (enabledTraking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (page != 0 && offset != 0)
            {
                query = query.Skip(offset * (page - 1)).Take(offset);
            }

            var result = orderBy != null
                ? await orderBy(query).ToListAsync()
                : await query.ToListAsync();


            if (result == null)
            {
                throw new ArgumentNullException($"Bad Request");
            }

            return result;
        }
    }
}
