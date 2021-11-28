using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD
{
    static class Program
    {
        public static bool debug = true;
        public static bool MAD_AAVD = true; //true = MAD - false = AAVD
        public static Usuario session;

        public static void VentanaPrincipal()
        {
            switch (session.empleadoCliente)
            {
                case 0:
                    {
                        FormClientePrincipal fPrincipal = new FormClientePrincipal();
                        fPrincipal.Show();
                    }
                    break;
                case 1:
                    {
                        FormEmpleadoPrincipal fPrincipal = new FormEmpleadoPrincipal();
                        fPrincipal.Show();
                    }
                    break;
                case 2:
                    {
                        FormAdministradorPrincipal fPrincipal = new FormAdministradorPrincipal();
                        fPrincipal.Show();
                    }
                    break;
            }
        }
        public static void CBFechaMes(ComboBox mes)
        {
            mes.Items.Clear();
            for(int i = 1; i <= 12; i++)
            {
                mes.Items.Add(i.ToString());
            }
            mes.SelectedIndex = DateTime.Today.Month - 1;
        }
        public static void CBFechaAño(ComboBox año)
        {
            año.Items.Clear();
            DateTime fecha = DateTime.Today;
            for (int i = fecha.Year; i > 1800; i--)
            {
                año.Items.Add(i.ToString());
            }
            año.SelectedIndex = 0;
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicioSesion());
        }
    }
}
