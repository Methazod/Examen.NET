using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using JorgeManzano.Modelos;

namespace JorgeManzano.Services
{        
    public class FutbolDBContext : DbContext 
    {
        public DbSet<Equipo> Equipo { get; set; } // Se tiene que llamar exactamente igual que la tabla de la bbdd
        public DbSet<Jugador> Jugador { get; set; } // Se tiene que llamar exactamente igual que la tabla de la bbdd
        public FutbolDBContext(DbContextOptions<FutbolDBContext> options) : base(options) { }
    }
}
