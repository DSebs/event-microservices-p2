using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente_Eventos.Cliente.Modelo
{
    public class Cancion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double duracion { get; set; }
        public DateTime fechaLanzamiento { get; set; }
        public string compositor { get; set; }

        public Cancion(int id, string nombre, double duracion, DateTime fechaLanzamiento, string compositor)
        {
            this.id = id;
            this.nombre = nombre;
            this.duracion = duracion;
            this.fechaLanzamiento = fechaLanzamiento;
            this.compositor = compositor;
        }
    }
}
