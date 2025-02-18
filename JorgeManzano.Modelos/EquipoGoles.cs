using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeManzano.Modelos
{
    public class EquipoGoles
    {
        public Equipo Equipo { get; set; }
        public int NumGoles { get; set; }
        public EquipoGoles(Equipo equipo, int num)
        {
            Equipo = equipo;
            NumGoles = num;
        }
    }
}
