using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Models.Entities
{
    public class Vehicle : EntityBase
    {
        public string TitularFirstName { get; set; }
        public string TitularLastName { get; set; }
        public long BrandId { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }

        public Brand Brand { get; set; }
    }
}
