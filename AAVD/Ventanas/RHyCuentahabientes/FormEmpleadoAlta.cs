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
        public bool nacimientoSel = false;
        public FormEmpleadoAlta()
        {
            InitializeComponent();
        }

        private void FormEmpleadoAlta_Load(object sender, EventArgs e)
        {
            nacimientoSel = false;
            mcNacimiento.MaxDate = DateTime.Now;
            try
            {
                Municipio.LlenarCB(cbMunicipio);
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
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
                Usuario usuario = null;
                bool v1 = (tbNombreUsuario.Text != "");
                bool v2 = (tbContraseña.Text != "");
                bool v3 = (tbNombre.Text != "");
                bool v4 = (tbApellidoPaterno.Text != "");
                bool v5 = (tbApellidoMaterno.Text != "");
                bool v6 = (tbNumero.Text != "");
                bool v7 = (tbCalle.Text != "");
                bool v8 = (tbColonia.Text != "");
                bool v9 = (cbMunicipio.SelectedIndex >= 0);
                bool v10 = (tbEmail.Text != "");
                bool v11 = (rbHombre.Checked || rbMujer.Checked);
                bool v12 = nacimientoSel;
                if (v1 && v2 && v3 && v4 && v5 && v6 && v7 && v8 && v9 && v10 && v11 && v12)
                {
                    char genero;
                    if (rbHombre.Checked)
                    {
                        genero = 'H';
                    }
                    else
                    {
                        genero = 'M';
                    }
                    usuario = new Usuario(tbNombreUsuario.Text, tbContraseña.Text, 1, 0, 0);
                    empleado = new Empleado(
                        0, tbNombreUsuario.Text,
                        tbNombre.Text, tbApellidoPaterno.Text, tbApellidoMaterno.Text,
                        mcNacimiento.SelectionRange.Start,
                        genero,
                        int.Parse(tbNumero.Text), tbCalle.Text, tbColonia.Text, cbMunicipio.SelectedItem.ToString(),
                        DateTime.Now
                        );
                    Usuario.Agregar(usuario);
                    Empleado.Agregar(empleado);
                    MessageBox.Show("Empleado agregado exitosamente.");
                    this.Hide();
                    FormEmpleadoAlta fPrincipal = new FormEmpleadoAlta();
                    fPrincipal.Show();
                }
            }
            catch(Exception except)
            {
                MessageBox.Show("Error: " + except);
            }
        }

        private void mcNacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            nacimientoSel = true;
        }
    }
}
