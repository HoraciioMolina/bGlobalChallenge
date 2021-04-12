using AutoMapper;
using bGlobalChallgenge.Domain.Repository;
using bGlobalChallgenge.Domain.Services;
using bGlobalChallgenge.Models.DTOs.Inputs;
using bGlobalChallgenge.Models.DTOs.Outputs;
using bGlobalChallgenge.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Services
{
    public class VehicleServices : IVehicleServices
    {
        private readonly IRepository<Vehicle> _vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleServices(IRepository<Vehicle> vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }
        public async Task Create(VehicleInput vehicleInput)
        {
            var vehicle = _mapper.Map<Vehicle>(vehicleInput);
            await _vehicleRepository.Create(vehicle);
        }

        public async Task<IEnumerable<VehicleOutput>> GetAll(int page, int offset)
        {
            var vehicles = await _vehicleRepository.GetAll(
                ord => ord.OrderBy(veh => veh.TitularLastName), 
                inc => inc.Include(veh => veh.Brand), true, page, offset);

            return _mapper.Map<IEnumerable<VehicleOutput>>(vehicles);
        }
    }
}
