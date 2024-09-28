using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente_Eventos.Cliente.Modelo
{
    public class Concierto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public DateTime fecha { get; set; }
        public string artista { get; set; }

        public Concierto(int id, string nombre, double precio, DateTime fecha, string artista)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.fecha = fecha;
            this.artista = artista;
        }

    }
}
