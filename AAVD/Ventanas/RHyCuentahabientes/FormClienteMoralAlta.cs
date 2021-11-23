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
    public partial class FormClienteMoralAlta : Form
    {
        public bool nacimientoSel = false;
        public FormClienteMoralAlta()
        {
            InitializeComponent();
        }
        private void FormClienteMoralAlta_Load(object sender, EventArgs e)
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
                ClienteMoral cliente = null;
                Usuario usuario = null;
                bool v1 = (tbNombreUsuario.Text != "");
                bool v2 = (tbContraseña.Text != "");
                bool v3 = (tbNombre.Text != "");
                bool v4 = (tbCURP.Text != "");
                bool v5 = (tbEmail.Text != "");
                bool v6 = nacimientoSel;
                if (v1 && v2 && v3 && v4 && v5 && v6)
                {
                    usuario = new Usuario(tbNombreUsuario.Text, tbContraseña.Text, 0, 0, 0);
                    cliente = new ClienteMoral(
                        tbCURP.Text, tbNombreUsuario.Text,
                        tbNombre.Text,
                        mcNacimiento.SelectionRange.Start,
                        tbEmail.Text,
                        DateTime.Now
                        );
                    Usuario.Agregar(usuario);
                    ClienteMoral.Agregar(cliente);
                    MessageBox.Show("Cliente moral agregado exitosamente.");
                    this.Hide();
                    FormClienteMoralAlta fPrincipal = new FormClienteMoralAlta();
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
