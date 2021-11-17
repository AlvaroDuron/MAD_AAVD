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
