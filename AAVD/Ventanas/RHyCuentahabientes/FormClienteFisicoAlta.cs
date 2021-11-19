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
                Usuario usuario = null;
                usuario.nombreUsuario = tbNombreUsuario.Text;
                usuario.contraseña = tbContraseña.Text;
                usuario.empleadoCliente = 0;
                usuario.intentos = 0;
                usuario.estado = 0;
                ClienteFisico cliente = null;
                cliente.nombreUsuario = usuario.nombreUsuario;
                cliente.nombre = tbNombre.Text;
                cliente.apellidoPaterno = tbApellidoPaterno.Text;
                cliente.apellidoMaterno = tbApellidoMaterno.Text;
                cliente.email = tbEmail.Text;
                cliente.curp = tbCURP.Text;
                //cliente.nacimiento
                //cliente.genero
                Usuario.Agregar(usuario);
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
