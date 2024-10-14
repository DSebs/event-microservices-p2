using Cliente_Eventos.Cliente.Modelo;
using Cliente_Eventos.Cliente.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Eventos.Cliente.Vista
{
    public partial class ListarCanciones : Form
    {
        private ServicioCancion servicioCancion;
        public ListarCanciones(ServicioCancion servicioCancion)
        {
            InitializeComponent();
            this.servicioCancion = servicioCancion;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cancion> listaCancion = servicioCancion.ListarCanciones();
                tblConciertos.DataSource = listaCancion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListarXDuracion_Click(object sender, EventArgs e)
        {
            try
            {
                double duracionMin = double.Parse(txtDuracionFiltro.Text, CultureInfo.InvariantCulture);
                string duracionMinString = duracionMin.ToString(CultureInfo.InvariantCulture);
                List<Cancion> listaCancion = servicioCancion.ListarCancionesMin(duracionMinString);
                tblConciertos.DataSource = listaCancion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtDuracionFiltro_Enter(object sender, EventArgs e)
        {
            if (txtDuracionFiltro.Text == "Digite la duracion minima")
            {
                txtDuracionFiltro.Text = "";
                txtDuracionFiltro.ForeColor = Color.Black;
            }
        }

    }
}
