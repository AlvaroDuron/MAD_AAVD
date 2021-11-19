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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.VentanaPrincipal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregarMoral_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClienteMoralAlta fPrincipal = new FormClienteMoralAlta();
            fPrincipal.Show();
        }

        private void btnAgregarFisico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClienteFisicoAlta fPrincipal = new FormClienteFisicoAlta();
            fPrincipal.Show();
        }
    }
}
