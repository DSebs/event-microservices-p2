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
    public partial class AgregarConcierto : Form
    {
        private ServicioConcierto servicioConcierto;
        public AgregarConcierto(ServicioConcierto servicioConcierto)
        {
            InitializeComponent();
            this.servicioConcierto = servicioConcierto;
        }       

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                string nombre = txtNombre.Text;
                double precio = Convert.ToDouble(txtPrecio.Text);
                DateTime fecha = dtpFecha.Value;
                string artista = txtArtista.Text;

                servicioConcierto.AgregarConcierto(id, nombre, precio, fecha, artista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
