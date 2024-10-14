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
    public partial class ActualizarCancion : Form
    {
        private ServicioCancion servicioCancion;
        public ActualizarCancion(ServicioCancion servicioCancion)
        {
            InitializeComponent();
            this.servicioCancion = servicioCancion;
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
                dtpFecha.Value = cancion.fechaLanzamiento;
                txtCompositor.Text = cancion.compositor;

                txtNombre.Enabled = true;
                txtDuracion.Enabled = true;
                txtCompositor.Enabled = true;
                dtpFecha.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idABuscar = Convert.ToInt32(txtBuscarID.Text);
                int id = Convert.ToInt32(txtID.Text);
                string nombre = txtNombre.Text;
                double duracion = Convert.ToDouble(txtDuracion.Text);
                DateTime fechaLanzamiento = dtpFecha.Value;
                string compositor = txtCompositor.Text;

                servicioCancion.ActualizarCancion(idABuscar, id, nombre, duracion, fechaLanzamiento, compositor);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
