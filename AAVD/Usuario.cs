using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD
{
    public class Usuario
    {
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public int empleadoCliente { get; set; }
        public byte intentos { get; set; }
        public byte estado { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nombre, string contraseña, byte empleado, byte intentos, byte estado)
        {
            this.nombreUsuario = nombre;
            this.contraseña = contraseña;
            this.empleadoCliente = empleado;
            this.intentos = intentos;
            this.estado = estado;
        }

        //BD QUERY
        public static void Consulta()
        {

        }

        public static void Modifica(Usuario usuario)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Usuario>("sp_ModificarUsuario",
                    new
                    {
                        @nombreUsuario = usuario.nombreUsuario,
                        @contraseña = usuario.contraseña,
                        @intentos = usuario.intentos,
                        @estado = usuario.estado
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
            
        }

        public static void Agrega()
        {

        }

        public static void Elimina(string usuario)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<Usuario>("sp_EliminarUsuario", new { @nombreUsuario = usuario }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }

        public static bool LogIn(string usuario, string contraseña, int empleadoCliente)
        {
            bool log = false;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                try
                {
                    var data = ConexionDB_MAD.db.Query<Usuario>("sp_BuscarUsuario", new { @nombreUsuario = usuario }, commandType: CommandType.StoredProcedure);
                    Usuario vusuario = data.ToList()[0];
                    //List<Usuario> usuarios = data.ToList();
                    if (vusuario.intentos < 5)
                    {
                        if (vusuario.contraseña == contraseña)
                        {
                            //login
                            if (vusuario.empleadoCliente == empleadoCliente)
                            {
                                vusuario.intentos = 0;
                                Program.session = vusuario;
                                log = true;
                            }
                            else
                            {
                                MessageBox.Show("Esa cuenta no coincide.");
                            }
                        }
                        else
                        {
                            vusuario.intentos++;
                            MessageBox.Show("Contraseña incorrecta.");
                        }
                    }
                    else
                    {
                        vusuario.estado = 3;
                        MessageBox.Show("La cuenta se ha suspendido por el momento.");
                    }
                    Modifica(vusuario);
                }
                catch (Exception except)
                {
                    MessageBox.Show("Error: " + except);
                }
                
                ConexionDB_MAD.desconectar();
            }
            else
            {


            }
            return log;
        }

    } 
}
