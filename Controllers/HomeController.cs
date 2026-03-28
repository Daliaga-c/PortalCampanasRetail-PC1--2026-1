using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PortalCampanas.Models; // Asegúrate que este sea el nombre de tu proyecto
using PortalCampanas.Data;

namespace PortalCampanas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(CampanaData.Listado);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}