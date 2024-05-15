using System.Collections.Generic;

namespace EjercicioClase1Modulo2.Ejercicio_2
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Kills { get; set; }
        public int Death { get; set; }
    }

    public class Estadistica
    {
        public string Equipo { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public bool Campeon { get; set; }
    }
}
