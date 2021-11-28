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
    public partial class FormRecibos : Form
    {
        bool cellSelected = false;
        int cellIndex;
        DataGridViewRow selectedRow;
        string keySelected;
        int cbIndex;
        public FormRecibos()
        {
            InitializeComponent();
            Program.CBFechaMes(cbMes);
            Program.CBFechaAño(cbAño);
            TipoServicio.LlenarCB(cbTipoServicio);
        }

        private void FormRecibos_Load(object sender, EventArgs e)
        {
            cellSelected = false;
            try
            {
                if (cbAño.SelectedIndex >= 0 && cbMes.SelectedIndex >= 0)
                {

                    if (rbTipoServicio.Checked == false)
                    {
                        Recibo.LlenarDG(dgvRecibo, int.Parse(cbAño.SelectedItem.ToString()), int.Parse(cbMes.SelectedItem.ToString()));
                    }
                    else
                    {
                        Recibo.LlenarDG(dgvRecibo, cbTipoServicio.SelectedItem.ToString(), int.Parse(cbAño.SelectedItem.ToString()), int.Parse(cbMes.SelectedItem.ToString()));
                    }
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.VentanaPrincipal();
        }

        private void bGenerar_Click(object sender, EventArgs e)
        {

        }

        private void rbTipoServicio_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTipoServicio.Checked == true)
            {
                cbTipoServicio.Enabled = true;
            }
            else
            {
                cbTipoServicio.Enabled = false;
            }
            FormRecibos_Load(sender, e);
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormRecibos_Load(sender, e);
        }

        private void cbTipoServicio_Click(object sender, EventArgs e)
        {
            //cbIndex = cbTipoServicio.SelectedIndex;
            //FormRecibos_Load(sender, e);
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormRecibos_Load(sender, e);
        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormRecibos_Load(sender, e);
        }
    }
}
