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
    public partial class FormCategorias : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        char catSelected;
        public FormCategorias()
        {
            InitializeComponent();
        }
        private void FormCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                Categoria.LlenarDG(dgvCategoria);
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                Categoria categoria = Categoria.Buscar(catSelected.ToString());

                Categoria modificado = new Categoria(
                    categoria.categoria, 
                    float.Parse(selectedRow.Cells["porcentaje"].Value.ToString())
                    );
                Categoria.Modificar(modificado);
            }
            FormCategorias_Load(sender, e);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.VentanaPrincipal();
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvCategoria.Rows[cellIndex];
            catSelected = char.Parse(selectedRow.Cells[0].Value.ToString());
        }
    }
}
