using System;
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
    public partial class FormAdministradorPrincipal : Form
    {
        public FormAdministradorPrincipal()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Program.session = null;
            this.Hide();
            FormInicioSesion fPrincipal = new FormInicioSesion();
            fPrincipal.Show();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente fPrincipal = new FormCliente();
            fPrincipal.Show();
        }

        private void bReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRecibos fPrincipal = new FormRecibos();
            fPrincipal.Show();
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
            FormTarifas fPrincipal = new FormTarifas();
            fPrincipal.Show();
        }

        private void bContratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContratos fPrincipal = new FormContratos();
            fPrincipal.Show();
        }

        private void bZonas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormZonas fPrincipal = new FormZonas();
            fPrincipal.Show();
        }

        private void bParametros_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormParametros fPrincipal = new FormParametros();
            fPrincipal.Show();
        }

        private void bEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleados fPrincipal = new FormEmpleados();
            fPrincipal.Show();
        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCategorias fPrincipal = new FormCategorias();
            fPrincipal.Show();
        }
    }
}
