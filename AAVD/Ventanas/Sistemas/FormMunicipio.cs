﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD
{
    public partial class FormMunicipio : Form
    {
        public FormMunicipio()
        {
            InitializeComponent();
        }

        private void FormMunicipio_Load(object sender, EventArgs e)
        {
            try
            {
                Municipio.LlenarDG(dgvMunicipio);
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.VentanaPrincipal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Municipio.Agregar(new Municipio(tbNombre.Text, int.Parse(tbNumeroZona.Text)));
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
            FormMunicipio_Load(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormMunicipio_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Municipio.Eliminar(tbNombre.Text);
            FormMunicipio_Load(sender, e);
        }
    }
}
