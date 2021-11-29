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
    public partial class FormTipoServicios : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        string tipoSelected;
        public FormTipoServicios()
        {
            InitializeComponent();
        }

        private void FormTipoServicios_Load(object sender, EventArgs e)
        {
            try
            {
                TipoServicio.LlenarDG(dgvTipoServicio);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                TipoServicio servicio = TipoServicio.Buscar(tipoSelected.ToString());

                TipoServicio modificado = new TipoServicio(
                    servicio.nombre,
                    float.Parse(selectedRow.Cells["cuotaDrenaje"].Value.ToString()),
                    float.Parse(selectedRow.Cells["rango1"].Value.ToString()),
                    float.Parse(selectedRow.Cells["rango2"].Value.ToString()),
                    float.Parse(selectedRow.Cells["rango3"].Value.ToString())
                    );
                TipoServicio.Modificar(modificado);
            }
            FormTipoServicios_Load(sender, e);
        }

        private void dgvTipoServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvTipoServicio.Rows[cellIndex];
            tipoSelected = selectedRow.Cells["nombre"].Value.ToString();
        }

        private void dgvTipoServicio_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4) // 1 should be your column index
            {
                float i;

                if (!float.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Ingrese solamente numeros.");
                }
                else
                {
                    // the input is numeric 
                }
            }
        }
    }
}
