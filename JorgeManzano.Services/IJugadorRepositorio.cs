using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JorgeManzano.Modelos;

namespace JorgeManzano.Services
{
    public interface IJugadorRepositorio
    {
        public IEnumerable<Jugador> getAllJugadores();
        public Jugador getJugador(int id);
        public Jugador addJugador(Jugador nuevoJugador);
        public Jugador removeJugador(int id);
        public Jugador updateJugador(Jugador nuevoJugador);
        public IEnumerable<Jugador> jugadoresPorEquipo(int? equipoID);
        public IEnumerable<EquipoCuantos> GetAllEquipoCuantos();
        public IEnumerable<EquipoGoles> GetAllEquipoGoles();
    }
}
