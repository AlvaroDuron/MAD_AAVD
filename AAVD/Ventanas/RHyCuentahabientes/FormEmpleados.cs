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
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        int idSelected;
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            cellSelected = false;
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
            if (cellSelected)
            {
                Empleado empleado = Empleado.Buscar(idSelected);

                Empleado modificado = new Empleado(
                    empleado.idEmpleado, empleado.nombreUsuario,
                    selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString(), selectedRow.Cells[4].Value.ToString(),
                    Convert.ToDateTime(selectedRow.Cells[5].Value.ToString()),
                    char.Parse(selectedRow.Cells[6].Value.ToString()),
                    int.Parse(selectedRow.Cells[7].Value.ToString()), selectedRow.Cells[8].Value.ToString(), selectedRow.Cells[9].Value.ToString(), selectedRow.Cells[10].Value.ToString(),
                    DateTime.Now
                    );
                Empleado.Modificar(modificado);
            }
            FormEmpleados_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                string nombreUsuario = Empleado.Buscar(idSelected).nombreUsuario;
                Empleado.Eliminar(idSelected);
                Usuario.Eliminar(nombreUsuario);
            }
            FormEmpleados_Load(sender, e);
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvEmpleados.Rows[cellIndex];
            idSelected = int.Parse(selectedRow.Cells[0].Value.ToString());
        }
    }
}
