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
    public partial class FormConsumos : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        string keySelected;
        public FormConsumos()
        {
            InitializeComponent();
        }

        private void FormConsumos_Load(object sender, EventArgs e)
        {
            cellSelected = false;
            try
            {
                Program.CBFechaMes(cbMes);
                Program.CBFechaAño(cbAño);
                Contrato.LlenarCB(cbNumeroMedidor);
                Consumo.LlenarDG(dgvConsumo);
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
                Consumo consumo = null;
                bool v1 = MostrarLecturaAnterior();
                bool v2 = (tbLecturaActual.Text != "");
                if(v1 && v2)
                {
                    Contrato contrato = Contrato.BuscarPorMedidor(int.Parse(cbNumeroMedidor.SelectedItem.ToString()));
                    consumo = new Consumo(
                        int.Parse(cbNumeroMedidor.SelectedItem.ToString()),
                        int.Parse(cbAño.SelectedItem.ToString()),
                        int.Parse(cbMes.SelectedItem.ToString()),
                        float.Parse(tbLecturaAnterior.Text.ToString()),
                        float.Parse(tbLecturaActual.Text.ToString()),
                        contrato.numeroContrato
                        );
                    if (Consumo.BuscarPorContrato(consumo.numeroContrato, consumo.año, consumo.mes) == null)
                    {
                        Consumo.Agregar(consumo);
                        MessageBox.Show("Lectura agregada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Esa lectura ya existe.");
                    }
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
            FormConsumos_Load(sender, e);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void cbNumeroMedidor_Leave(object sender, EventArgs e)
        {
            MostrarLecturaAnterior();
        }

        private void cbAño_Leave(object sender, EventArgs e)
        {
            MostrarLecturaAnterior();
        }

        private void cbMes_Leave(object sender, EventArgs e)
        {
            MostrarLecturaAnterior();
        }
        private bool MostrarLecturaAnterior()
        {
            bool temp = false;
            bool v1 = (cbNumeroMedidor.SelectedIndex >= 0);
            bool v2 = (cbAño.SelectedIndex >= 0);
            bool v3 = (cbMes.SelectedIndex >= 0);
            if(v1 && v2 && v3)
            {
                Contrato contrato = Contrato.BuscarPorMedidor(int.Parse(cbNumeroMedidor.SelectedItem.ToString()));
                int año = int.Parse(cbAño.SelectedItem.ToString());
                int mes = int.Parse(cbMes.SelectedItem.ToString());
                if (mes > 1)
                {
                    mes--;
                }
                else
                {
                    mes = 12;
                    año--;
                }
                Consumo anterior = Consumo.BuscarPorContrato(contrato.numeroContrato, año, mes);
                if (anterior != null)
                {
                    tbLecturaAnterior.Text = anterior.lecturaActual.ToString();
                }
                else
                {
                    tbLecturaAnterior.Text = "0";
                }
                temp = true;
            }
            return temp;
        }
    }
}
