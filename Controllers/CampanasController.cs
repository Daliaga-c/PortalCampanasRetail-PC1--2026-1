using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Data;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index()
        {
            // Enviamos la lista a la vista
            var campanas = CampanaData.Listado;
            return View(campanas);
        }
    }
}