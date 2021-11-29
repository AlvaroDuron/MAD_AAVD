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
                TipoServicio.LlenarCB(cbTipoServicio);
                Contrato.LlenarDG(dgvContrato);
                if (rbClientesFisicos.Checked)
                {
                    ClienteFisico.LlenarCB(cbCliente);
                }
                else
                {
                    ClienteMoral.LlenarCB(cbCliente);
                }
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

        private void rbClientesFisicos_Click(object sender, EventArgs e)
        {
            rbClientesFisicos.Checked = true;
            rbClientesMorales.Checked = false;
            FormContratos_Load(sender, e);
        }

        private void rbClientesMorales_Click(object sender, EventArgs e)
        {
            rbClientesFisicos.Checked = false;
            rbClientesMorales.Checked = true;
            FormContratos_Load(sender, e);
        }
    }
}
