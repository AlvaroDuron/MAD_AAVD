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
    public partial class FormContratos : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        int serieSelected;
        public FormContratos()
        {
            InitializeComponent();
        }

        private void FormContratos_Load(object sender, EventArgs e)
        {
            cellSelected = false;
            try
            {
                Contrato.LlenarDG(dgvContrato);
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

        private void bAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContratoAlta fPrincipal = new FormContratoAlta();
            fPrincipal.Show();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
