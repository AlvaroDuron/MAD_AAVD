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
                if(tbNombreUsuario.Text == "" || tbContraseña.Text == "" || tbNombre.Text == "")
                Empleado.Agregar(empleado);
                MessageBox.Show("Empleado agregado exitosamente.");
                this.Hide();
                FormEmpleados fPrincipal = new FormEmpleados();
                fPrincipal.Show();
            }
        }
    }
}
