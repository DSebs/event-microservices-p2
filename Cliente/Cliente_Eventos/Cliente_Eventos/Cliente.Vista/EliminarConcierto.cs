using Cliente_Eventos.Cliente.Modelo;
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

namespace Cliente_Eventos.Cliente.Vista
{
    public partial class EliminarConcierto : Form
    {
        private ServicioConcierto servicioConcierto;
        public EliminarConcierto(ServicioConcierto servicioConcierto)
        {
            InitializeComponent();
            this.servicioConcierto = servicioConcierto;
        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void EliminarConcierto_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBuscarID_Enter(object sender, EventArgs e)
        {
            if (txtBuscarID.Text == "Digite el ID")
            {
                txtBuscarID.Text = "";
                txtBuscarID.ForeColor = Color.Black; // Cambia el color del texto si es necesario
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtBuscarID.Text);
                Concierto concierto = servicioConcierto.BuscarConciertoPorId(id);
                txtID.Text = concierto.id.ToString();
                txtNombre.Text = concierto.nombre;
                txtPrecio.Text = concierto.precio.ToString();
                txtFecha.Text = concierto.fecha.ToString();
                txtArtista.Text = concierto.artista;
                txtCancionesIds.Text = string.Join(", ", concierto.cancionesIds);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtBuscarID.Text);
                servicioConcierto.EliminarConcierto(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
