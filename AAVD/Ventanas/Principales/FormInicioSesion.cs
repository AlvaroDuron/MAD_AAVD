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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }
        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
            cbEmpleado.SelectedIndex = 0;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int selectedIndex = cbEmpleado.SelectedIndex;
            bool log = Usuario.LogIn(tbUsuario.Text, tbContraseña.Text, selectedIndex);
            if (log)
            {
                this.Hide();
                Program.VentanaPrincipal();
            }
        }
        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUsuario.Text) && !string.IsNullOrEmpty(tbContraseña.Text))
                btnIngresar.Enabled = true;
            else
                btnIngresar.Enabled = false;
        }
        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUsuario.Text) && !string.IsNullOrEmpty(tbContraseña.Text))
                btnIngresar.Enabled = true;
            else
                btnIngresar.Enabled = false;
        }
        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
        private void tbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbMAD_Click(object sender, EventArgs e)
        {
            cbMAD.Checked = true;
            cbAAVD.Checked = false;
            Program.MAD_AAVD = false;
        }

        private void cbAAVD_Click(object sender, EventArgs e)
        {
            cbMAD.Checked = false;
            cbAAVD.Checked = true;
            Program.MAD_AAVD = true;
        }
    }
}
