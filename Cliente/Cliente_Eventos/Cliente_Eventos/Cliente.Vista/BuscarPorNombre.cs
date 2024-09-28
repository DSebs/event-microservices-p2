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
    public partial class BuscarPorNombre : Form
    {
        public BuscarPorNombre()
        {
            InitializeComponent();
        }

        private void txtBuscarNombre_Enter(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text == "Digite el nombre")
            {
                txtBuscarNombre.Text = "";
                txtBuscarNombre.ForeColor = Color.Black; 
            }
        }

    }
}
