using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        private static List<Campana> _campanas = new List<Campana>
        {
            new Campana { Id = 1, Nombre = "Cierra Puertas", Categoria = "Tecnología", Estado = "Vigente", FechaInicio = DateTime.Now.AddDays(-2), FechaFin = DateTime.Now.AddDays(5), DescuentoPct = 40, Canal = "Web", Descripcion = "Descuentos en laptops" },
            new Campana { Id = 2, Nombre = "Renueva tu Hogar", Categoria = "Hogar", Estado = "Próxima", FechaInicio = DateTime.Now.AddDays(10), FechaFin = DateTime.Now.AddDays(20), DescuentoPct = 25, Canal = "Tienda", Descripcion = "Muebles y decoración" },
            new Campana { Id = 3, Nombre = "Cyber Moda", Categoria = "Moda", Estado = "Finalizada", FechaInicio = DateTime.Now.AddDays(-30), FechaFin = DateTime.Now.AddDays(-15), DescuentoPct = 60, Canal = "App", Descripcion = "Remate de temporada" }
        };

        public IActionResult Index()
        {
            ViewBag.TotalCampanas = _campanas.Count; // O algo similar del resumen
            return View(_campanas);
        }

        public IActionResult Detalle(int id)
        {
            var campana = _campanas.FirstOrDefault(c => c.Id == id);
            if (campana == null) return NotFound();
            return View(campana);
        }
    }
}