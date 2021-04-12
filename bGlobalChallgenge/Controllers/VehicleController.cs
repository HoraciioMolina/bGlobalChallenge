using bGlobalChallgenge.Domain.Services;
using bGlobalChallgenge.Models.DTOs.Inputs;
using bGlobalChallgenge.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bGlobalChallgenge.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleServices _vehicleServices;
        private readonly IBrandServices _brandServices;

        public VehicleController(IVehicleServices vehicleServices,
            IBrandServices brandServices)
        {
            _vehicleServices = vehicleServices;
            _brandServices = brandServices;
        }

        public async Task<IActionResult> Index()
        {
            var vehicleOutputs = await _vehicleServices.GetAll(0, 0);
            return View(vehicleOutputs);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var brands = await _brandServices.GetAll(0, 0);
            var vehicle = new VehicleInput()
            {
                Brands = GetBrandsItems(brands)
            };

            return View(vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> Create(VehicleInput vehicleInput)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _vehicleServices.Create(vehicleInput);
                }
                else
                {
                    var brands = await _brandServices.GetAll(0, 0);
                    vehicleInput.Brands = GetBrandsItems(brands);
                    return View(vehicleInput);
                }

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(vehicleInput);
            }

            return RedirectToAction("Index");
        }

        private static SelectList GetBrandsItems(IEnumerable<Brand> brands)
        {
            return new SelectList(brands, nameof(Brand.Id), nameof(Brand.Name));
        }
    }
}
