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
    public partial class BuscarPorNombreCancion : Form
    {
        private ServicioCancion servicioCancion;
        public BuscarPorNombreCancion(ServicioCancion servicioCancion)
        {
            InitializeComponent();
            this.servicioCancion = servicioCancion;
        }

        private void txtBuscarID_Enter(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text == "Digite el nombre")
            {
                txtBuscarNombre.Text = "";
                txtBuscarNombre.ForeColor = Color.Black;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreABuscar = (txtBuscarNombre.Text);
                Cancion cancion = servicioCancion.BuscarCancionPorNombre(nombreABuscar);
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
    }
}
