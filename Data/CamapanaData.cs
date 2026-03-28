using PortalCampanas.Models;

namespace PortalCampanas.Data
{
    public static class CampanaData
    {
        public static List<Campana> Listado = new List<Campana>
        {
            new Campana { Id = 1, Nombre = "Cyber Pro", Categoria = "Tecnología", Estado = "Vigente", FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(7), DescuentoPct = 30, Canal = "Web", Descripcion = "Ofertas en laptops" },
            new Campana { Id = 2, Nombre = "Deco Hogar", Categoria = "Hogar", Estado = "Próxima", FechaInicio = DateTime.Now.AddDays(10), FechaFin = DateTime.Now.AddDays(20), DescuentoPct = 15, Canal = "Tienda", Descripcion = "Muebles de sala" },
            new Campana { Id = 3, Nombre = "Moda Invierno", Categoria = "Moda", Estado = "Finalizada", FechaInicio = DateTime.Now.AddMonths(-1), FechaFin = DateTime.Now.AddDays(-5), DescuentoPct = 50, Canal = "App", Descripcion = "Liquidación de temporada" }
        };
    }
}