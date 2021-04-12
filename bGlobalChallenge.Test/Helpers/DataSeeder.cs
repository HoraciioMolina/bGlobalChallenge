using bGlobalChallgenge.Models.Entities;
using bGlobalChallgenge.Persistence.Context;
using System.Linq;

namespace bGlobalChallenge.Test.Helpers
{
    public class DataSeeder
    {
        public static void SeedVehicles(DataContext context)
        {
            if (context.Vehicles.Any())
                return;

            context.Vehicles.AddRange(
                new Vehicle { Id = 1, TitularFirstName="Horacio", TitularLastName="Molina",  BrandId = 1, Doors = 5, Model = "Gol" });

            context.SaveChanges();
        }
    }
}
