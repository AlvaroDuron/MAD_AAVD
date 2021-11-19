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
        public FormClienteFisicoAlta()
        {
            InitializeComponent();
        }

        private void FormClienteFisicoAlta_Load(object sender, EventArgs e)
        {

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteFisico cliente = null;
                cliente.usuario.nombreUsuario = tbNombreUsuario.Text;
                cliente.usuario.contraseña = tbContraseña.Text;
                cliente.nombre = tbNombre.Text;
                cliente.curp = tbCURP.Text;
                //cliente.domicilio
                cliente.email = tbEmail.Text;
                //cliente.genero
                //cliente.nacimiento
                ClienteFisico.Agregar(cliente);
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
    }
}
