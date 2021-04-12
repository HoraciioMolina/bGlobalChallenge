using AutoMapper;
using bGlobalChallgenge.Models.DTOs.Inputs;
using bGlobalChallgenge.Models.DTOs.Outputs;
using bGlobalChallgenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bGlobalChallenge.Test.Helpers
{
    public class MapperGenerator
    {
        public static Mapper VehiclesMapper()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.CreateMap<VehicleInput, Vehicle>();
                config.CreateMap<Vehicle, VehicleOutput>();
                config.CreateMap<Brand, BrandOutput>();

            });
            return new Mapper(configuration);
        }
    }
}
