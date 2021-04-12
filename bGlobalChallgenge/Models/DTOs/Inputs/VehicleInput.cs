using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bGlobalChallgenge.Models.DTOs.Inputs
{
    public class VehicleInput
    {
        [Required(ErrorMessage = "El campo titular es requerido")]
        [DisplayName("Nombre del titular")]
        public string TitularFirstName { get; set; }

        [Required(ErrorMessage = "El campo titular es requerido")]
        [DisplayName("Apellido del titular")]
        public string TitularLastName { get; set; }

        [DisplayName("Marca")]
        public long BrandId { get; set; }

        [Required(ErrorMessage = "El campo modelo es requerido")]
        [DisplayName("Modelo")]
        public string Model { get; set; }

        [Range(1, 10, ErrorMessage = "El campo puestas es requerido. Minimo {1} Maximo {2}")]
        [DisplayName("Puertas")]
        public int Doors { get; set; }

        public IEnumerable<SelectListItem> Brands { get; set; }

    }
}
