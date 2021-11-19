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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                Empleado.LlenarDG(dgvEmpleados);
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.VentanaPrincipal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleadoAlta fPrincipal = new FormEmpleadoAlta();
            fPrincipal.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            FormEmpleados_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            FormEmpleados_Load(sender, e);
        }
    }
}
