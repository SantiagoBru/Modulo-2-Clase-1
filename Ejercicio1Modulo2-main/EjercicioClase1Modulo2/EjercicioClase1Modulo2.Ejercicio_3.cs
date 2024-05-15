using System.Collections.Generic;

namespace EjercicioClase1Modulo2.Ejercicio_3
{
    public class Dimensiones
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public int Profundidad { get; set; }
    }

    public class Detalles
    {
        public double Peso { get; set; }
        public Dimensiones Dimensiones { get; set; }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Existencias { get; set; }
        public bool DescuentoDisponible { get; set; }
        public List<string> Etiquetas { get; set; }
        public Detalles Detalles { get; set; }
    }

    public class Ejercicio3
    {
        public List<Producto> Productos { get; set; }
    }
}
