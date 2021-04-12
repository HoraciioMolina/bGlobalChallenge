using bGlobalChallgenge.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Domain.Services
{
    public interface IBrandServices
    {
        Task<IEnumerable<Brand>> GetAll(int page, int offset);
    }
}