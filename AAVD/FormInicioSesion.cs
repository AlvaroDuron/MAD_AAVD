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
            if (Program.debug)
            {
                Size = new Size(400, 300);
                Debugtxt.Visible = true;
            }
            else
            {
                Size = new Size(400, 170);
                Debugtxt.Visible = false;
            }

            if (Program.MAD_AAVD)
            {

            }
            else
            {

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Program.MAD_AAVD)
            {

            }
            else
            {

            }

            Debugtxt.Text = Debugtxt.Text + "\nusuario: " + tbUsuario.Text + "\ncontraseña: " + tbContraseña.Text;
        }

        private void cbEmpleado_Click(object sender, EventArgs e)
        {

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
