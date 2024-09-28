using Cliente_Eventos.Cliente.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Eventos
{
    public partial class FramePrincipal : Form
    {
        public FramePrincipal()
        {
            InitializeComponent();
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
            AgregarConcierto agregarConcierto = new AgregarConcierto();
            agregarConcierto.Show();
        }

        private void eliminarConciertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarConcierto eliminarConcierto = new EliminarConcierto();
            eliminarConcierto.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarConciertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarConcierto actualizarConcierto = new ActualizarConcierto();
            actualizarConcierto.Show();
        }

        private void buscarPorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPorId buscarPorID = new BuscarPorId();
            buscarPorID.Show();

        }

        private void buscarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPorNombre buscarPorNombre = new BuscarPorNombre();
            buscarPorNombre.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

        private void listarConciertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarConciertos listarConciertos = new ListarConciertos();
            listarConciertos.Show();
        }
    }
}
