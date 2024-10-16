﻿using Cliente_Eventos.Cliente.Modelo;
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
    public partial class ActualizarConcierto : Form
    {
        private ServicioConcierto servicioConcierto;
        public ActualizarConcierto(ServicioConcierto servicioConcierto)
        {
            InitializeComponent();
            this.servicioConcierto = servicioConcierto;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtBuscarID.Text);
                Concierto concierto = servicioConcierto.BuscarConciertoPorId(id);
                txtID.Text = concierto.id.ToString();
                txtNombre.Text = concierto.nombre;
                txtPrecio.Text = concierto.precio.ToString();
                dtpFecha.Value = concierto.fecha;
                txtArtista.Text = concierto.artista;
                txtCancionesIds.Text = string.Join(", ", concierto.cancionesIds);

                txtNombre.Enabled = true;
                txtPrecio.Enabled = true;
                txtArtista.Enabled = true;
                dtpFecha.Enabled = true;
                txtCancionesIds.Enabled = true;

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
                double precio = Convert.ToDouble(txtPrecio.Text);
                DateTime fecha = dtpFecha.Value;
                string artista = txtArtista.Text;

                List<int> cancionesIds;

                if (string.IsNullOrWhiteSpace(txtCancionesIds.Text))
                {
                    cancionesIds = new List<int>();
                }
                else
                {
                    cancionesIds = txtCancionesIds.Text
                                    .Split(',')
                                    .Select(int.Parse)
                                    .ToList();
                }
                servicioConcierto.ActualizarConcierto(idABuscar, id, nombre, precio, fecha, artista, cancionesIds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarConcierto_Load(object sender, EventArgs e)
        {

        }
    }
}
