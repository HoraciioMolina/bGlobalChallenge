using bGlobalChallgenge.Controllers;
using bGlobalChallgenge.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace bGlobalChallenge.Test
{
    [TestClass]
    public class VehiclesControllerTest
    {
        [TestMethod]
        public async Task Get_Vehicles_Return_200_With_Vehicles()
        {
            var moqVehicleService = new Mock<IVehicleServices>();
            var moqBrandService = new Mock<IBrandServices>();


            var data = await new VehicleController(moqVehicleService.Object, moqBrandService.Object).Index();
            
            Assert.IsInstanceOfType(data, typeof(ViewResult));
        }
    }
}
