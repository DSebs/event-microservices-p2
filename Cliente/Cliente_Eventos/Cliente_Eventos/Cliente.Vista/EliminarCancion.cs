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
    public partial class EliminarCancion : Form
    {
        private ServicioCancion servicioCancion;
        public EliminarCancion(ServicioCancion servicioCancion)
        {
            InitializeComponent();
            this.servicioCancion = servicioCancion;
        }

        private void txtBuscarID_Enter(object sender, EventArgs e)
        {
            if (txtBuscarID.Text == "Digite el ID")
            {
                txtBuscarID.Text = "";
                txtBuscarID.ForeColor = Color.Black;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtBuscarID.Text);
                Cancion cancion = servicioCancion.BuscarCancionPorId(id);
                txtID.Text = cancion.id.ToString();
                txtNombre.Text = cancion.nombre;
                txtDuracion.Text = cancion.duracion.ToString();
                txtFecha.Text = cancion.fechaLanzamiento.ToString();
                txtCompositor.Text = cancion.compositor;
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
                servicioCancion.EliminarCancion(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
