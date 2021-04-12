using AutoMapper;
using bGlobalChallgenge.Domain.Repository;
using bGlobalChallgenge.Domain.Services;
using bGlobalChallgenge.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Services
{
    public class BrandServices : IBrandServices
    {
        private readonly IRepository<Brand> _brandRepository;
        private readonly IMapper _mapper;

        public BrandServices(IRepository<Brand> brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Brand>> GetAll(int page, int offset)
        {
            var vehicles = await _brandRepository.GetAll(
                ord => ord.OrderBy(brand => brand.Name),
                null, true, page, offset);

            return _mapper.Map<IEnumerable<Brand>>(vehicles);
        }
    }
}