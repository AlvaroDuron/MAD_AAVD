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
                if (rbClientesFisicos.Checked)
                {
                    //this.dgvClienteFisico.Columns["rfc"].Visible = false;
                    //this.dgvClienteFisico.Columns["constitucion"].Visible = false;
                    ClienteFisico.LlenarDG(dgvClienteFisico);
                }
                else
                {
                    //this.dgvClienteFisico.Columns["curp"].Visible = false;
                    //this.dgvClienteFisico.Columns["apellidoPaterno"].Visible = false;
                    //this.dgvClienteFisico.Columns["apellidoMaterno"].Visible = false;
                    //this.dgvClienteFisico.Columns["nacimiento"].Visible = false;
                    //this.dgvClienteFisico.Columns["genero"].Visible = false;
                    ClienteMoral.LlenarDG(dgvClienteFisico);
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
                if (rbClientesFisicos.Checked)
                {

                    ClienteFisico cliente = ClienteFisico.Buscar(keySelected);

                    ClienteFisico modificado = new ClienteFisico(
                        cliente.curp, cliente.nombreUsuario,
                        selectedRow.Cells["nombre"].Value.ToString(), selectedRow.Cells["apellidoPaterno"].Value.ToString(), selectedRow.Cells["apellidoMaterno"].Value.ToString(),
                        Convert.ToDateTime(selectedRow.Cells["nacimiento"].Value.ToString()),
                        char.Parse(selectedRow.Cells["genero"].Value.ToString()),
                        selectedRow.Cells["email"].Value.ToString(),
                        DateTime.Now
                        );
                    ClienteFisico.Modificar(modificado);
                }
                else
                {
                    ClienteMoral cliente = ClienteMoral.Buscar(keySelected);

                    ClienteMoral modificado = new ClienteMoral(
                        cliente.rfc, cliente.nombreUsuario,
                        selectedRow.Cells["nombre"].Value.ToString(),
                        Convert.ToDateTime(selectedRow.Cells["constitucion"].Value.ToString()),
                        selectedRow.Cells["email"].Value.ToString(),
                        DateTime.Now
                        );
                    ClienteMoral.Modificar(modificado);
                }
            }
            FormCliente_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                if (rbClientesFisicos.Checked)
                {
                    string nombreUsuario = ClienteFisico.Buscar(keySelected).nombreUsuario;
                    ClienteFisico.Eliminar(keySelected);
                    Usuario.Eliminar(nombreUsuario);
                }
                else
                {
                    string nombreUsuario = ClienteMoral.Buscar(keySelected).nombreUsuario;
                    ClienteMoral.Eliminar(keySelected);
                    Usuario.Eliminar(nombreUsuario);
                }
            }
            FormCliente_Load(sender, e);
        }

        private void dgvClienteFisico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvClienteFisico.Rows[cellIndex];
            if (rbClientesFisicos.Checked)
            {
                keySelected = selectedRow.Cells["curp"].Value.ToString();
            }
            else
            {
                keySelected = selectedRow.Cells["rfc"].Value.ToString();
            }
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
