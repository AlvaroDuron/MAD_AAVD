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
    public partial class FormMunicipio : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        string keySelected;
        public FormMunicipio()
        {
            InitializeComponent();
        }

        private void FormMunicipio_Load(object sender, EventArgs e)
        {
            try
            {
                Municipio.LlenarDG(dgvMunicipio);
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
            try
            {
                Municipio.Agregar(new Municipio(tbNombre.Text, int.Parse(tbNumeroZona.Text)));
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
            FormMunicipio_Load(sender, e);
        }

        //private void btnModificar_Click(object sender, EventArgs e)
        //{
        //    if (cellSelected)
        //    {
        //        Municipio modificado = new Municipio(selectedRow.Cells["municipio"].ToString(), int.Parse(selectedRow.Cells["numeroZona"].Value.ToString()));
        //    }
        //    FormMunicipio_Load(sender, e);
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                Municipio.Eliminar(selectedRow.Cells["municipio"].ToString());
            }
            FormMunicipio_Load(sender, e);
        }

        private void dgvMunicipio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvMunicipio.Rows[cellIndex];
            keySelected = selectedRow.Cells[0].Value.ToString();
        }
    }
}
