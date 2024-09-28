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
    public partial class ActualizarConcierto : Form
    {
        public ActualizarConcierto()
        {
            InitializeComponent();
        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarID_Enter(object sender, EventArgs e)
        {
            if (txtBuscarID.Text == "Digite el ID")
            {
                txtBuscarID.Text = "";
                txtBuscarID.ForeColor = Color.Black; 
            }
        }

    }
}
