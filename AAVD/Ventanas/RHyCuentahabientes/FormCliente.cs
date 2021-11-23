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
    public partial class FormCliente : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        string keySelected;
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            cellSelected = false;
            try
            {
                ClienteFisico.LlenarDG(dgvClienteFisico);
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
        private void btnAgregarFisico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClienteFisicoAlta fPrincipal = new FormClienteFisicoAlta();
            fPrincipal.Show();
        }

        private void btnAgregarMoral_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClienteMoralAlta fPrincipal = new FormClienteMoralAlta();
            fPrincipal.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                ClienteFisico cliente = ClienteFisico.Buscar(keySelected);

                ClienteFisico modificado = new ClienteFisico(
                    cliente.curp, cliente.nombreUsuario,
                    selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString(), selectedRow.Cells[4].Value.ToString(),
                    Convert.ToDateTime(selectedRow.Cells[5].Value.ToString()),
                    char.Parse(selectedRow.Cells[6].Value.ToString()),
                    selectedRow.Cells[7].Value.ToString(),
                    DateTime.Now
                    );
                ClienteFisico.Modificar(modificado);
            }
            FormCliente_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                Usuario.Eliminar(ClienteFisico.Buscar(keySelected).nombreUsuario);
                ClienteFisico.Eliminar(keySelected);
            }
            FormCliente_Load(sender, e);
        }

        private void dgvClienteFisico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvClienteFisico.Rows[cellIndex];
            keySelected = selectedRow.Cells[0].Value.ToString();
        }

        private void rbClientesFisicos_Click(object sender, EventArgs e)
        {
            rbClientesFisicos.Checked = true;
            rbClientesMorales.Checked = false;
            FormCliente_Load(sender, e);
        }

        private void rbClientesMorales_Click(object sender, EventArgs e)
        {
            rbClientesFisicos.Checked = false;
            rbClientesMorales.Checked = true;
            FormCliente_Load(sender, e);
        }
    }
}
