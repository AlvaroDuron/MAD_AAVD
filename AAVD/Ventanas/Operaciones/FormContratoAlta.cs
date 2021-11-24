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
    public partial class FormContratoAlta : Form
    {
        public FormContratoAlta()
        {
            InitializeComponent();
        }

        private void FormContratoAlta_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Contrato contrato = null;
                //bool v1 = (tbNombreUsuario.Text != "");
                bool v2 = (tbNumeroMedidor.Text != "");
                bool v3 = (cbCategoria.SelectedIndex >= 0);
                bool v4 = (cbTipoServicio.SelectedIndex >= 0);
                bool v5 = (tbNumeroExterior.Text != "");
                bool v6 = (tbCalle.Text != "");
                bool v7 = (tbColonia.Text != "");
                bool v8 = (cbMunicipio.SelectedIndex >= 0);
                bool v9 = (cbEstatus.SelectedIndex >= 0);
                bool vrfc = (tbRfc.Text != "");
                bool vcurp = (tbCurp.Text != "");
                bool v10 = (vcurp != vrfc);
                if (v10 && v2 && v3 && v4 && v5 && v6 && v7 && v8 && v9)
                {
                    string clave;
                    if (vrfc)
                    {
                        clave = tbRfc.Text;
                    }
                    else
                    {
                        clave = tbCurp.Text;
                    }
                    contrato = new Contrato(
                        cbUsuario.SelectedItem.ToString(),
                        0, int.Parse(tbNumeroMedidor.Text),
                        char.Parse(cbCategoria.SelectedItem.ToString()), cbTipoServicio.SelectedItem.ToString(),
                        int.Parse(tbNumeroExterior.Text), tbCalle.Text, tbColonia.Text, cbMunicipio.SelectedItem.ToString(),
                        byte.Parse(cbEstatus.SelectedItem.ToString()),
                        DateTime.Now, DateTime.Now
                        );
                    Contrato.Agregar(contrato);
                    MessageBox.Show("Contrato agregado exitosamente.");
                    this.Hide();
                    FormContratoAlta fPrincipal = new FormContratoAlta();
                    fPrincipal.Show();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContratos fPrincipal = new FormContratos();
            fPrincipal.Show();
        }
    }
}
