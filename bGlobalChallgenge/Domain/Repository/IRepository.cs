using bGlobalChallgenge.Models.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Domain.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        Task Create(T entity);

        // ==================================================================================//

        Task<IEnumerable<T>> GetAll(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
          Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
          bool enabledTraking = true, int page = 0, int offset = 0);

        //===============================================================================//
    }
}
