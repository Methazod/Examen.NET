using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JorgeManzano.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace JorgeManzano.Services
{
    public class JugadorRepositorioDB : IJugadorRepositorio
    {
        public FutbolDBContext context;
        public JugadorRepositorioDB(FutbolDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Jugador> getAllJugadores()
        {
            return context.Jugador;
        }
        public Jugador getJugador(int id)
        {
            return context.Jugador.Find(id);
        }
        public Jugador addJugador(Jugador nuevoJugador)
        {
            context.Jugador.Add(nuevoJugador);
            context.SaveChanges();
            return nuevoJugador;
        }
        public Jugador removeJugador(int id)
        {
            Jugador jugador = getJugador(id);
            context.Jugador.Remove(jugador);
            context.SaveChanges();
            return jugador;
        }
        public Jugador updateJugador(Jugador nuevoJugador)
        {
            Jugador jugador = getJugador(nuevoJugador.id);
            jugador.nomJugador = nuevoJugador.nomJugador;
            jugador.foto = nuevoJugador.foto;
            jugador.numGoles = nuevoJugador.numGoles;
            jugador.equipoID = nuevoJugador.equipoID;
            context.SaveChanges();
            return jugador;
        }
        public IEnumerable<Jugador> jugadoresPorEquipo(int? equipoID)
        {
            if (equipoID.HasValue && equipoID.Value != 0)
            {
                return context.Jugador.Where(a => a.equipoID == equipoID).ToList();
            }
            return getAllJugadores();
        }
        public IEnumerable<EquipoCuantos> GetAllEquipoCuantos()
        {            
            List<EquipoCuantos> equipos = new List<EquipoCuantos>();
            
            foreach(Equipo equipo in context.Equipo)
            {
                equipos.Add(new EquipoCuantos(equipo, jugadoresPorEquipo(equipo.id).Count()));
            }

            IEnumerable<EquipoCuantos> equipoCuantos = equipos;
            return equipoCuantos;            
        }
        public IEnumerable<EquipoGoles> GetAllEquipoGoles()
        {            
            List<EquipoGoles> equipos = new List<EquipoGoles>();

            foreach (Equipo equipo in context.Equipo)
            {
                int numGoles = 0;
                foreach(Jugador jugador in jugadoresPorEquipo(equipo.id))
                {
                    numGoles += jugador.numGoles;
                }
                equipos.Add(new EquipoGoles(equipo, numGoles));
            }
            IEnumerable<EquipoGoles> equipoGoles = equipos;
            return equipoGoles;
        }
    }
}
