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
    public partial class ListarConciertos : Form
    {
        public ListarConciertos()
        {
            InitializeComponent();
        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrecioFiltro_Enter(object sender, EventArgs e)
        {
            if (txtPrecioFiltro.Text == "Digite el precio minimo")
            {
                txtPrecioFiltro.Text = "";
                txtPrecioFiltro.ForeColor = Color.Black; // Cambia el color del texto si es necesario
            }
        }

    }
}
