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
    public partial class FormZonas : Form
    {
        public FormZonas()
        {
            InitializeComponent();
        }

        private void FormZonas_Load(object sender, EventArgs e)
        {
            try
            {
                Zona.LlenarDG(dgvZona);
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormZonas_Load(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Zona.Agrega(int.Parse(tbNumeroZona.Text), tbMunicipio.Text);
            } catch(Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
            FormZonas_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Zona.Elimina(tbMunicipio.Text);
            FormZonas_Load(sender, e);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
