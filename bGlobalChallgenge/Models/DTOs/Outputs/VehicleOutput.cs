using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Models.DTOs.Outputs
{
    public class VehicleOutput : OutputBase
    {
        public string TitularFirstName { get; set; }
        public string TitularLastName { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }

        public BrandOutput Brand { get; set; }
    }
}
