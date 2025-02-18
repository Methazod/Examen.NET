using JorgeManzano.Services;
using Microsoft.AspNetCore.Mvc;

namespace JorgeManzano.Components
{
    public class NumJugadoresPorClubViewComponent : ViewComponent
    {
        IJugadorRepositorio jugadorRepositorio;
        public NumJugadoresPorClubViewComponent(IJugadorRepositorio jr)
        {
            jugadorRepositorio = jr;
        }
        public IViewComponentResult Invoke()
        {
            return View(jugadorRepositorio.GetAllEquipoCuantos());
        }
    }
}
