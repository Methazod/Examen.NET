using JorgeManzano.Services;
using JorgeManzano.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JorgeManzano.Pages.Jugadores
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int equipoID { get; set; }
        private IJugadorRepositorio JugadorRepositorio { get; }
        public IEquipoRepositorio EquipoRepositorio { get; }
        public IEnumerable<Jugador> listaJugadores;
        public IEnumerable<Equipo> listaEquipos;
        public IndexModel(IJugadorRepositorio jugadorRepositorio, IEquipoRepositorio equipoRepositorio)
        {
            JugadorRepositorio = jugadorRepositorio;
            EquipoRepositorio = equipoRepositorio;
        }        

        public void OnGet()
        {            
            listaJugadores = JugadorRepositorio.jugadoresPorEquipo(equipoID);                      
            listaEquipos = EquipoRepositorio.getAllEquipos();
        }
    }
}
