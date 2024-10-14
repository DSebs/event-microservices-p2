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
    public partial class AgregarCancion : Form
    {
        private ServicioCancion servicioCancion;
        public AgregarCancion(ServicioCancion servicioCancion)
        {
            InitializeComponent();
            this.servicioCancion = servicioCancion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                string nombre = txtNombre.Text;
                double duracion = Convert.ToDouble(txtDuracion.Text);
                DateTime fechaLanzamiento = dtpFecha.Value;
                string compositor = txtCompositor.Text;

                servicioCancion.AgregarCancion(id, nombre, duracion, fechaLanzamiento, compositor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
