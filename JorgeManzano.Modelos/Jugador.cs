using System.ComponentModel.DataAnnotations;
namespace JorgeManzano.Modelos
{
    public class Jugador
    {
        public int id { get; set; }
        public string nomJugador { get; set; }
        public string foto { get; set; }
        public int numGoles { get; set; }
        public int equipoID { get; set; }
    }
}
