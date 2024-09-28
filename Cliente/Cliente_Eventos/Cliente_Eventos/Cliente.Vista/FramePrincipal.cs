using Cliente_Eventos.Cliente.Vista;
using Cliente_Eventos.Cliente.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace Cliente_Eventos
{
    public partial class FramePrincipal : Form
    {
        private ServicioConcierto servicioConcierto;
        private RestClientOptions options;
        private RestClient client;
        public FramePrincipal()
        {
            InitializeComponent();
            options = new RestClientOptions("http://localhost:8090/evento/concierto");
            client = new RestClient(options);
            servicioConcierto = new ServicioConcierto(client);

        }

        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FramePrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarConciertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarConcierto agregarConcierto = new AgregarConcierto(servicioConcierto);
            agregarConcierto.Show();
        }

        private void eliminarConciertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarConcierto eliminarConcierto = new EliminarConcierto(servicioConcierto);
            eliminarConcierto.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarConciertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarConcierto actualizarConcierto = new ActualizarConcierto(servicioConcierto);
            actualizarConcierto.Show();
        }

        private void buscarPorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPorId buscarPorID = new BuscarPorId(servicioConcierto);
            buscarPorID.Show();

        }

        private void buscarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPorNombre buscarPorNombre = new BuscarPorNombre(servicioConcierto);
            buscarPorNombre.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

        private void listarConciertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarConciertos listarConciertos = new ListarConciertos(servicioConcierto);
            listarConciertos.Show();
        }
    }
}
