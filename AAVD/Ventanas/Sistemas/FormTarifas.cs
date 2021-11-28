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
    public partial class FormTarifas : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        int zoneSelected;
        string servSelected;
        int yearSelected;
        int montSelected;
        public FormTarifas()
        {
            InitializeComponent();
        }

        private void FormTarifas_Load(object sender, EventArgs e)
        {
            try
            {
                Program.CBFechaAño(cbAño);
                Program.CBFechaMes(cbMes);
                Program.CBFechaAño(cbFiltroAño);
                Program.CBFechaMes(cbFiltroMes);
                Zona.LlenarCB(cbZona);
                Zona.LlenarCB(cbFiltroZona);
                TipoServicio.LlenarCB(cbTipoServicio);
                Tarifa.LlenarDG(dgvTarifas);
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
                Tarifa tarifa = null;
                bool v1 = (cbZona.SelectedIndex >= 0);
                bool v2 = (cbTipoServicio.SelectedIndex >= 0);
                bool v3 = (cbAño.SelectedIndex >= 0);
                bool v4 = (cbMes.SelectedIndex >= 0);
                bool v5 = (tbCuotaFija.Text != "");
                bool v6 = (tbRango1.Text != "");
                bool v7 = (tbRango2.Text != "");
                bool v8 = (tbRango3.Text != "");
                if(v1 && v2 && v3 && v4 && v5 && v6 && v7 && v8)
                {
                    Zona zona = Zona.BuscarPorNombre(cbZona.SelectedItem.ToString());
                    tarifa = new Tarifa(
                        zona.numeroZona, cbTipoServicio.SelectedItem.ToString(),
                        int.Parse(cbAño.SelectedItem.ToString()), int.Parse(cbMes.SelectedItem.ToString()),
                        float.Parse(tbCuotaFija.Text.ToString()),
                        float.Parse(tbRango1.Text.ToString()),
                        float.Parse(tbRango2.Text.ToString()),
                        float.Parse(tbRango3.Text.ToString())
                        );
                    if(Tarifa.Buscar(tarifa.numeroZona, tarifa.tipoServicio, tarifa.año, tarifa.mes) == null)
                    {
                        Tarifa.Agregar(tarifa);
                        MessageBox.Show("Tarifa agregada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Esa tarifa ya existe.");
                    }
                    //try
                    //{
                    //    Tarifa vtarifa = Tarifa.Buscar(tarifa.numeroZona, tarifa.tipoServicio, tarifa.año, tarifa.mes);
                    //    MessageBox.Show("Esa tarifa ya existe.");
                    //}
                    //catch (Exception except)
                    //{
                    //    Tarifa.Agregar(tarifa);
                    //    MessageBox.Show("Tarifa agregada exitosamente.");
                    //}
                }
                FormTarifas_Load(sender, e);
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
                Tarifa tarifa = Tarifa.Buscar(zoneSelected, servSelected, yearSelected, montSelected);
                Tarifa modificado = new Tarifa(
                    tarifa.numeroZona, tarifa.tipoServicio, tarifa.año, tarifa.mes,
                    float.Parse(selectedRow.Cells["cuotaFija"].Value.ToString()),
                    float.Parse(selectedRow.Cells["rango1"].Value.ToString()),
                    float.Parse(selectedRow.Cells["rango2"].Value.ToString()),
                    float.Parse(selectedRow.Cells["rango3"].Value.ToString())
                    );
                Tarifa.Modificar(modificado);
            }
            FormTarifas_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                Tarifa.Eliminar(zoneSelected, servSelected, yearSelected, montSelected);
            }
            FormTarifas_Load(sender, e);
        }

        private void dgvTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            cellIndex = e.RowIndex;
            selectedRow = dgvTarifas.Rows[cellIndex];
            zoneSelected = int.Parse(selectedRow.Cells["numeroZona"].Value.ToString());
            servSelected = selectedRow.Cells["tipoServicio"].Value.ToString();
            yearSelected = int.Parse(selectedRow.Cells["año"].Value.ToString());
            montSelected = int.Parse(selectedRow.Cells["mes"].Value.ToString());
        }

        private void dgvTarifas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int cell = e.ColumnIndex;
            if (cell == 2 || cell == 3 || cell == 4 || cell == 5 || cell == 6 || cell == 7) // 1 should be your column index
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
