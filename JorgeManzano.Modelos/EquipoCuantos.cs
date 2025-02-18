using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JorgeManzano.Modelos
{
    public class EquipoCuantos
    {
        public Equipo Equipo { get; set; }
        public int NumJugadores { get; set; }
        public EquipoCuantos(Equipo equipo, int num)
        {
            Equipo = equipo;
            NumJugadores = num;
        }
    }
}
