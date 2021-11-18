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
            try
            {
                Categoria.Modificar(char.Parse(tbCategoria.Text), int.Parse(tbPorcentaje.Text));
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
            FormCategorias_Load(sender, e);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Program.VentanaPrincipal();
            FormCategorias_Load(sender, e);
        }

    }
}
