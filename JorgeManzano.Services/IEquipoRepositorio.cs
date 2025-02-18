using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JorgeManzano.Modelos;

namespace JorgeManzano.Services
{
    public interface IEquipoRepositorio
    {
        public IEnumerable<Equipo> getAllEquipos();
        public Equipo getEquipo(int id);
        public Equipo addEquipo(Equipo nuevoEquipo);
        public Equipo removeEquipo(int id);
        public Equipo updateEquipo(Equipo nuevoEquipo);
    }
}
