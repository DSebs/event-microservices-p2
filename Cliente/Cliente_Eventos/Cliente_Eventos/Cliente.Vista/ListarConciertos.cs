﻿using Cliente_Eventos.Cliente.Modelo;
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
    public partial class ListarConciertos : Form
    {
        private ServicioConcierto servicioConcierto;
        public ListarConciertos(ServicioConcierto servicioConcierto)
        {
            InitializeComponent();
            this.servicioConcierto = servicioConcierto;
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Concierto> listaConciertos = servicioConcierto.ListarConciertos();
                var conciertosModificados = listaConciertos.Select(c => new
                {
                    c.id,
                    c.nombre,
                    c.precio,
                    c.fecha,
                    c.artista,
                    CancionIDs = string.Join(", ", c.cancionesIds)
                }).ToList();

                tblConciertos.DataSource = conciertosModificados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnListarXPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                double precioMin = double.Parse(txtPrecioFiltro.Text, CultureInfo.InvariantCulture);
                string precioMinString = precioMin.ToString(CultureInfo.InvariantCulture);

                List<Concierto> listaConciertos = servicioConcierto.ListarConciertosMin(precioMinString);
                var conciertosModificados = listaConciertos.Select(c => new
                {
                    c.id,
                    c.nombre,
                    c.precio,
                    c.fecha,
                    c.artista,
                    CancionIDs = string.Join(", ", c.cancionesIds)
                }).ToList();
                tblConciertos.DataSource = conciertosModificados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ListarConciertos_Load(object sender, EventArgs e)
        {

        }
    }
}
