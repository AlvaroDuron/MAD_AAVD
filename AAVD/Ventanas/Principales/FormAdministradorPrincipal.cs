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
    public partial class FormAdministradorPrincipal : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        string keySelected;
        public FormAdministradorPrincipal()
        {
            InitializeComponent();
        }

        private void FormAdministradorPrincipal_Load(object sender, EventArgs e)
        {
            cellSelected = false;
            try
            {
                Empleado.LlenarDGBan(dgvEmpleadosBaneados);
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

        private void bMunicipios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMunicipio fPrincipal = new FormMunicipio();
            fPrincipal.Show();
        }

        private void bEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleados fPrincipal = new FormEmpleados();
            fPrincipal.Show();
        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCategorias fPrincipal = new FormCategorias();
            fPrincipal.Show();
        }

        private void bTipoServicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTipoServicios fPrincipal = new FormTipoServicios();
            fPrincipal.Show();
        }

        private void bActivar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                Usuario empleado = Usuario.Buscar(keySelected);
                empleado.estado = 1;
                empleado.intentos = 0;
                Usuario.Modificar(empleado);
            }
            FormAdministradorPrincipal_Load(sender, e);
        }

        private void dgvEmpleadosBaneados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvEmpleadosBaneados.Rows[cellIndex];
            keySelected = selectedRow.Cells["nombreUsuario"].Value.ToString();
        }

    }
}
