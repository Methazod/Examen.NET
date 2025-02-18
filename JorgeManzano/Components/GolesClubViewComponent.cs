using JorgeManzano.Services;
using Microsoft.AspNetCore.Mvc;

namespace JorgeManzano.Components
{
    public class GolesClubViewComponent : ViewComponent
    {
        IJugadorRepositorio jugadorRepositorio;
        public GolesClubViewComponent(IJugadorRepositorio jr)
        {
            jugadorRepositorio = jr;
        }
        public IViewComponentResult Invoke()
        {
            return View(jugadorRepositorio.GetAllEquipoGoles());
        }
    }
}
