using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JorgeManzano.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace JorgeManzano.Services
{
    public class EquipoRepositorioDB : IEquipoRepositorio
    {
        public FutbolDBContext context;
        public EquipoRepositorioDB(FutbolDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Equipo> getAllEquipos()
        {
            return context.Equipo;
        }
        public Equipo getEquipo(int id)
        {
            return context.Equipo.Find(id);
        }
        public Equipo addEquipo(Equipo nuevoEquipo)
        {
            context.Equipo.Add(nuevoEquipo);
            context.SaveChanges();
            return nuevoEquipo;
        }
        public Equipo removeEquipo(int id)
        {
            Equipo equipo = getEquipo(id);
            context.Equipo.Remove(equipo);
            return equipo;
        }
        public Equipo updateEquipo(Equipo nuevoEquipo)
        {
            Equipo equipo = getEquipo(nuevoEquipo.id);            
            equipo.nomEquipo = nuevoEquipo.nomEquipo;            
            context.SaveChanges();
            return equipo;
        }
    }
}
