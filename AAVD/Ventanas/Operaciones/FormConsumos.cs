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
                bool v1 = (cbNumeroMedidor.SelectedIndex >= 0);
                bool v2 = (cbAño.SelectedIndex >= 0);
                bool v3 = (cbMes.SelectedIndex >= 0);
                bool v4 = (tbLecturaActual.Text != "");
                if(v1 || v2 || v3 || v4)
                {
                    Contrato contrato = Contrato.BuscarPorMedidor(int.Parse(cbNumeroMedidor.SelectedItem.ToString()));
                    consumo = new Consumo(
                        int.Parse(cbNumeroMedidor.SelectedItem.ToString()),
                        int.Parse(cbAño.SelectedItem.ToString()),
                        int.Parse(cbMes.SelectedItem.ToString()),
                        0,
                        float.Parse(tbLecturaActual.Text.ToString()),
                        contrato.numeroContrato
                        );
                    if (Consumo.BuscarPorContrato(consumo.numeroContrato, consumo.año, consumo.mes) == null)
                    {
                        Consumo anterior = consumo;
                        if (consumo.mes > 1)
                        {
                            anterior.mes--;
                        }
                        else
                        {
                            anterior.mes = 12;
                            anterior.año--;
                        }
                        anterior = Consumo.BuscarPorContrato(anterior.numeroContrato, anterior.año, anterior.mes);
                        if (anterior != null)
                        {
                            consumo.lecturaAnterior = anterior.lecturaActual;
                            Consumo.Agregar(consumo);
                            MessageBox.Show("Lectura agregada exitosamente.");
                        }
                        else
                        {
                            Consumo.Agregar(consumo);
                            MessageBox.Show("Lectura agregada exitosamente.");
                        }
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
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }
    }
}
