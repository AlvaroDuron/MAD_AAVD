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
    public partial class FormEmpleadoPrincipal : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        string keySelected;
        public FormEmpleadoPrincipal()
        {
            InitializeComponent();
        }

        private void FormEmpleadoPrincipal_Load(object sender, EventArgs e)
        {
            cellSelected = false;
            try
            {
                if (rbClientesFisicos.Checked)
                {
                    ClienteFisico.LlenarDGBan(dgvClientesBaneados);
                }
                else
                {
                    ClienteMoral.LlenarDGBan(dgvClientesBaneados);
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Program.session = null;
            this.Hide();
            FormInicioSesion fPrincipal = new FormInicioSesion();
            fPrincipal.Show();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente fPrincipal = new FormCliente();
            fPrincipal.Show();
        }

        private void bReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRecibos fPrincipal = new FormRecibos();
            fPrincipal.Show();
        }

        private void bTarifas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTarifas fPrincipal = new FormTarifas();
            fPrincipal.Show();
        }

        private void bConsumos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsumos fPrincipal = new FormConsumos();
            fPrincipal.Show();
        }

        private void bContratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContratos fPrincipal = new FormContratos();
            fPrincipal.Show();
        }

        private void bZonas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormZonas fPrincipal = new FormZonas();
            fPrincipal.Show();
        }

        private void bRecibos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRecibos fPrincipal = new FormRecibos();
            fPrincipal.Show();
        }

        private void bConsumoHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsumoHistorico fPrincipal = new FormConsumoHistorico();
            fPrincipal.Show();
        }

        private void rbClientesFisicos_Click(object sender, EventArgs e)
        {
            rbClientesFisicos.Checked = true;
            rbClientesMorales.Checked = false;
            FormEmpleadoPrincipal_Load(sender, e);
        }

        private void rbClientesMorales_Click(object sender, EventArgs e)
        {
            rbClientesFisicos.Checked = false;
            rbClientesMorales.Checked = true;
            FormEmpleadoPrincipal_Load(sender, e);
        }

        private void bActivar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                Usuario cliente = Usuario.Buscar(keySelected);
                cliente.estado = 1;
                cliente.intentos = 0;
                Usuario.Modificar(cliente);
            }
            FormEmpleadoPrincipal_Load(sender, e);
        }

        private void dgvClientesBaneados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvClientesBaneados.Rows[cellIndex];
            keySelected = selectedRow.Cells["nombreUsuario"].Value.ToString();
        }
    }
}
