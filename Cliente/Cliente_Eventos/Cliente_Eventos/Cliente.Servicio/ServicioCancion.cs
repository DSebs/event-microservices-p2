using Cliente_Eventos.Cliente.Modelo;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Eventos.Cliente.Servicio
{
    public class ServicioCancion
    {
        private readonly RestClient _client;
        public ServicioCancion(RestClient client)
        {
            _client = client;
        }

        public void AgregarCancion(int id, string nombre, double duracion, DateTime lanzamiento, string compositor)
        {
            Cancion cancion = new Cancion(id, nombre, duracion, lanzamiento, compositor);
            var jsonBody = JsonConvert.SerializeObject(cancion);

            var request = new RestRequest("/add", Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(jsonBody, DataFormat.Json);

            var response = _client.Execute(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Error al agregar cancion: {response.ErrorMessage}");
            }
            else
            {
                MessageBox.Show("Cancion creada exitosamente");
            }
        }

        public Cancion BuscarCancionPorId(int id)
        {
            var request = new RestRequest($"/buscar/id/{id}", Method.Get);
            var response = _client.Execute<Cancion>(request);
            if (response.IsSuccessful)
            {
                Cancion cancion = JsonConvert.DeserializeObject<Cancion>(response.Content);
                return cancion;
            }
            else
            {
                throw new Exception("Error al obetener los datos de la cancion");
            }
        }

        public Cancion BuscarCancionPorNombre(string nombre)
        {
            var request = new RestRequest($"/buscar/nombre/{nombre}", Method.Get);
            var response = _client.Execute<Cancion>(request);
            if (response.IsSuccessful)
            {
                Cancion cancion = JsonConvert.DeserializeObject<Cancion>(response.Content);
                return cancion;
            }
            else
            {
                throw new Exception("Error al obetener los datos de la cancion");
            }
        }

        public void ActualizarCancion(int idCancionExistente, int id, string nombre, double duracion, DateTime lanzamiento, string compositor)
        {
            Cancion cancion = new Cancion(id, nombre, duracion, lanzamiento, compositor);
            var jsonBody = JsonConvert.SerializeObject(cancion);

            var request = new RestRequest($"/{idCancionExistente}", Method.Put);

            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(jsonBody, DataFormat.Json);

            var response = _client.Execute(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error al actualizar cancion: {response.ErrorMessage}");
            }
            else
            {
                MessageBox.Show("Cancion actualizada con exito");
            }
        }

        public void EliminarCancion(int id)
        {
            Cancion cancion = BuscarCancionPorId(id);
            var jsonBody = JsonConvert.SerializeObject(cancion);
            var request = new RestRequest($"/eliminar", Method.Delete);

            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(jsonBody, DataFormat.Json);

            var response = _client.Execute(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error al eliminar cancion: {response.ErrorMessage}");
            }
            else
            {
                MessageBox.Show("Cancion eliminada exitosamente");
            }
        }

        public List<Cancion> ListarCanciones()
        {
            var request = new RestRequest("/listar", Method.Get);
            var response = _client.Execute(request);

            if (response.IsSuccessful)
            {
                List<Cancion> canciones = JsonConvert.DeserializeObject<List<Cancion>>(response.Content);
                return canciones;
            }
            else
            {
                throw new Exception($"Error al listar canciones: {response.ErrorMessage}");
            }
        }

        public List<Cancion> ListarCancionesMin(double duracionMin)
        {
            var request = new RestRequest($"/listar/duracion/{duracionMin}", Method.Get);
            var response = _client.Execute(request);

            if (response.IsSuccessful)
            {
                List<Cancion> canciones = JsonConvert.DeserializeObject<List<Cancion>>(response.Content);
                return canciones;
            }
            else
            {
                throw new Exception($"Error al listar canciones con duracion mínima {duracionMin}: {response.ErrorMessage}");
            }
        }
    }
}
