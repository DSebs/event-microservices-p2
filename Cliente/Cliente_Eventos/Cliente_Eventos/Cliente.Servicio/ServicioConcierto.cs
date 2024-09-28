using Cliente_Eventos.Cliente.Modelo;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cliente_Eventos.Cliente.Servicio
{
    public class ServicioConcierto
    {
        private readonly RestClient _client;

        public ServicioConcierto(RestClient client)
        {
            _client = client;
        }

        public void AgregarConcierto(int id, string nombre, double precio, DateTime fecha, string artista)
        {
            Concierto concierto = new Concierto(id, nombre, precio, fecha, artista);
            var jsonBody = JsonConvert.SerializeObject(concierto);

            var request = new RestRequest("/add", Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(jsonBody, DataFormat.Json);

            var response = _client.Execute(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error al agregar concierto: {response.ErrorMessage}");
            }
        }

        public Concierto BuscarConciertoPorId(int id)
        {
            var request = new RestRequest($"/buscar/id/{id}", Method.Get);
            var response = _client.Execute<Concierto>(request);
            if (response.IsSuccessful)
            {
                Concierto concierto = JsonConvert.DeserializeObject<Concierto>(response.Content);
                return concierto;
            }
            else
            {
                throw new Exception("Error al obetener los datos del concierto");
            }
        }

        public Concierto BuscarConciertoPorNomrbe(string nombre)
        {
            var request = new RestRequest($"/buscar/nombre/{nombre}", Method.Get);
            var response = _client.Execute<Concierto>(request);
            if (response.IsSuccessful)
            {
                Concierto concierto = JsonConvert.DeserializeObject<Concierto>(response.Content);
                return concierto;
            }
            else
            {
                throw new Exception("Error al obetener los datos del concierto");
            }
        }

        public void ActualizarConcierto(int idConciertoExistente, int id, string nombre, double precio, DateTime fecha, string artista)
        {
            Concierto concierto = new Concierto(id, nombre, precio, fecha, artista);
            var jsonBody = JsonConvert.SerializeObject(concierto);

            var request = new RestRequest($"/{idConciertoExistente}", Method.Put);

            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(jsonBody, DataFormat.Json);

            var response = _client.Execute(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error al actualizar concierto: {response.ErrorMessage}");
            }
        }

        // Asegurar validacion por si el buscar falla
        public void EliminarConcierto(int id)
        {
            Concierto concierto = BuscarConciertoPorId(id);
            var jsonBody = JsonConvert.SerializeObject(concierto);
            var request = new RestRequest($"/eliminar", Method.Delete);

            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(jsonBody, DataFormat.Json);

            var response = _client.Execute(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error al eliminar concierto: {response.ErrorMessage}");
            }
        }

        public List<Concierto> ListarConciertos()
        {
            var request = new RestRequest("/listar", Method.Get);
            var response = _client.Execute(request);

            if (response.IsSuccessful)
            {
                List<Concierto> conciertos = JsonConvert.DeserializeObject<List<Concierto>>(response.Content);
                return conciertos;
            }
            else
            {
                throw new Exception($"Error al listar conciertos: {response.ErrorMessage}");
            }
        }

        public List<Concierto> ListarConciertosMin(double precioMin)
        {
            var request = new RestRequest($"/listar/precio/{precioMin}", Method.Get);
            var response = _client.Execute(request);

            if (response.IsSuccessful)
            {
                List<Concierto> conciertos = JsonConvert.DeserializeObject<List<Concierto>>(response.Content);
                return conciertos;
            }
            else
            {
                throw new Exception($"Error al listar conciertos con precio mínimo {precioMin}: {response.ErrorMessage}");
            }
        }
    }
}
