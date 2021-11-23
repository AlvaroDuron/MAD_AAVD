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
    public partial class FormClientePrincipal : Form
    {
        public FormClientePrincipal()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicioSesion fPrincipal = new FormInicioSesion();
            fPrincipal.Show();
        }
        private void bContratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContratos fPrincipal = new FormContratos();
            fPrincipal.Show();
        }
        private void bRecibos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRecibos fPrincipal = new FormRecibos();
            fPrincipal.Show();
        }

        private void bConsumos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsumos fPrincipal = new FormConsumos();
            fPrincipal.Show();
        }
    }
}
