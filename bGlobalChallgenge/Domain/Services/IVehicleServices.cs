using bGlobalChallgenge.Models.DTOs.Inputs;
using bGlobalChallgenge.Models.DTOs.Outputs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Domain.Services
{
    public interface IVehicleServices
    {
        Task Create(VehicleInput vehicle);

        Task<IEnumerable<VehicleOutput>> GetAll(int page, int offset);
    }
}
