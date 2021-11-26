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
            try
            {
                
                Usuario.LlenarCB(cbUsuario);
                Municipio.LlenarCB(cbMunicipio);
                Categoria.LlenarCB(cbCategoria);
                TipoServicio.LlenarCB(cbTipoServicio);
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Contrato contrato = null;
                bool v1 = (cbUsuario.SelectedIndex >= 0);
                bool v2 = (tbNumeroMedidor.Text != "");
                bool v3 = (cbCategoria.SelectedIndex >= 0);
                bool v4 = (cbTipoServicio.SelectedIndex >= 0);
                bool v5 = (tbNumeroExterior.Text != "");
                bool v6 = (tbCalle.Text != "");
                bool v7 = (tbColonia.Text != "");
                bool v8 = (cbMunicipio.SelectedIndex >= 0);
                bool v9 = (cbEstatus.SelectedIndex >= 0);
                if (v1 && v2 && v3 && v4 && v5 && v6 && v7 && v8 && v9)
                {
                    byte estado;
                    if(cbEstatus.SelectedIndex == 0)
                    {
                        estado = 1;
                    }
                    else
                    {
                        estado = 0;
                    }
                    contrato = new Contrato(
                        cbUsuario.SelectedItem.ToString(),
                        0, int.Parse(tbNumeroMedidor.Text),
                        char.Parse(cbCategoria.SelectedItem.ToString()), cbTipoServicio.SelectedItem.ToString(),
                        int.Parse(tbNumeroExterior.Text), tbCalle.Text, tbColonia.Text, cbMunicipio.SelectedItem.ToString(),
                        estado,
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
