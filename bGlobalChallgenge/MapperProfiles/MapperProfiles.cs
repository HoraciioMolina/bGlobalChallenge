using AutoMapper;
using bGlobalChallgenge.Models.DTOs.Inputs;
using bGlobalChallgenge.Models.DTOs.Outputs;
using bGlobalChallgenge.Models.Entities;

namespace bGlobalChallgenge.MapperProfiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<VehicleInput, Vehicle>();
            CreateMap<Vehicle, VehicleOutput>();

            CreateMap<Brand, BrandOutput>();
        }
    }
}
