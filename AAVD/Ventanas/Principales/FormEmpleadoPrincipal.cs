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
    public partial class FormEmpleadoPrincipal : Form
    {
        public FormEmpleadoPrincipal()
        {
            InitializeComponent();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente fPrincipal = new FormCliente();
            fPrincipal.Show();
        }

        private void bReportes_Click(object sender, EventArgs e)
        {

        }

        private void bTarifas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTarifas fPrincipal = new FormTarifas();
            fPrincipal.Show();
        }

        private void bConsumos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsumos fPrincipal = new FormConsumos();
            fPrincipal.Show();
        }

        private void bContratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionContratos fPrincipal = new FormGestionContratos();
            fPrincipal.Show();
        }

        private void bZonas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormZonas fPrincipal = new FormZonas();
            fPrincipal.Show();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicioSesion fPrincipal = new FormInicioSesion();
            fPrincipal.Show();
        }
    }
}