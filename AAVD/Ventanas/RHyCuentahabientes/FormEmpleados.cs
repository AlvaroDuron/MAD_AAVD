using Dapper;
using Cassandra;
using Cassandra.Mapping;
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
        Guid idSelected;
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
                    selectedRow.Cells["nombre"].Value.ToString(), selectedRow.Cells["apellidoPaterno"].Value.ToString(), selectedRow.Cells["apellidoMaterno"].Value.ToString(),
                    LocalDate.Parse(selectedRow.Cells["nacimiento"].Value.ToString()),
                    selectedRow.Cells["genero"].Value.ToString(),
                    int.Parse(selectedRow.Cells["numeroExterior"].Value.ToString()), selectedRow.Cells["calle"].Value.ToString(), selectedRow.Cells["colonia"].Value.ToString(), selectedRow.Cells["municipio"].Value.ToString(),
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
            idSelected = Guid.Parse(selectedRow.Cells["idEmpleado"].Value.ToString());
        }
    }
}
