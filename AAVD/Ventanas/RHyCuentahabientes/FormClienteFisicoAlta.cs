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
    public partial class FormClienteFisicoAlta : Form
    {
        public bool nacimientoSel = false;
        public FormClienteFisicoAlta()
        {
            InitializeComponent();
        }

        private void FormClienteFisicoAlta_Load(object sender, EventArgs e)
        {
            nacimientoSel = false;
            mcNacimiento.MaxDate = DateTime.Now;
            try
            {

            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente fPrincipal = new FormCliente();
            fPrincipal.Show();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteFisico cliente = null;
                Usuario usuario = null;
                bool v1 = (tbNombreUsuario.Text != "");
                bool v2 = (tbContraseña.Text != "");
                bool v3 = (tbNombre.Text != "");
                bool v4 = (tbApellidoPaterno.Text != "");
                bool v5 = (tbApellidoMaterno.Text != "");
                bool v6 = (tbCURP.Text != "");
                bool v7 = (tbEmail.Text != "");
                bool v8 = (rbHombre.Checked || rbMujer.Checked);
                bool v9 = nacimientoSel;
                if (v1 && v2 && v3 && v4 && v5 && v6 && v7 && v8 && v9)
                {
                    string genero;
                    if (rbHombre.Checked)
                    {
                        genero = "Hombre";
                    }
                    else
                    {
                        genero = "Mujer";
                    }
                    usuario = new Usuario(tbNombreUsuario.Text, tbContraseña.Text, 0, 0, 1);
                    cliente = new ClienteFisico(
                        tbCURP.Text, tbNombreUsuario.Text,
                        tbNombre.Text, tbApellidoPaterno.Text, tbApellidoMaterno.Text,
                        mcNacimiento.SelectionRange.Start,
                        genero,
                        tbEmail.Text,
                        DateTime.Now
                        );
                    Usuario.Agregar(usuario);
                    ClienteFisico.Agregar(cliente);
                    MessageBox.Show("Cliente fisico agregado exitosamente.");
                    this.Hide();
                    FormClienteFisicoAlta fPrincipal = new FormClienteFisicoAlta();
                    fPrincipal.Show();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void mcNacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            nacimientoSel = true;
        }
    }
}
