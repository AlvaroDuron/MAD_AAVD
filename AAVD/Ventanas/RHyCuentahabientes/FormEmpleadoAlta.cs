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
    public partial class FormEmpleadoAlta : Form
    {
        public FormEmpleadoAlta()
        {
            InitializeComponent();
        }

        private void FormEmpleadoAlta_Load(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleados fPrincipal = new FormEmpleados();
            fPrincipal.Show();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = null;
                bool v1 = (tbNombreUsuario.Text == "");
                bool v2 = (tbContraseña.Text == "");
                bool v3 = (tbNombre.Text == "");
                bool v4 = (tbApellidoPaterno.Text == "");
                bool v5 = (tbApellidoMaterno.Text == "");
                bool v6 = (tbNumero.Text == "");
                bool v7 = (tbCalle.Text == "");
                bool v8 = (tbColonia.Text == "");
                bool v9 = (tbMunicipio.Text == "");
                bool v10 = (tbEmail.Text == "");
                if (v1 || v2 || v3 || v4 || v5 || v6 || v7 || v8 || v9 || v10)
                {
                    Empleado.Agregar(empleado);
                    MessageBox.Show("Empleado agregado exitosamente.");
                    this.Hide();
                    FormEmpleados fPrincipal = new FormEmpleados();
                    fPrincipal.Show();
                }
            }
            catch(Exception except)
            {

            }
        }
    }
}
