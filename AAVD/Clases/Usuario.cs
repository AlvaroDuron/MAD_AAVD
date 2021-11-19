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
        public Usuario(string nombreUsuario, string contraseña, byte empleado, byte intentos, byte estado)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.empleadoCliente = empleado;
            this.intentos = intentos;
            this.estado = estado;
        }

        //BD QUERY
        public static Usuario Buscar(string nombreUsuario)
        {
            Usuario temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Usuario>("sp_BuscarUsuario", new { @nombreUsuario = nombreUsuario }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
            return temp;
        }
        public static void Agregar(Usuario usuario)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Usuario>("sp_AgregarUsuario",
                    new
                    {
                        @nombreUsuario = usuario.nombreUsuario,
                        @contraseña = usuario.contraseña,
                        @empleadoCliente = usuario.empleadoCliente,
                        @intentos = usuario.intentos,
                        @estado = usuario.estado
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO Usuario(nombreUsuario, contraseña, empleadoCliente, intentos, estado)" +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}'); ",
                    usuario.nombreUsuario, usuario.contraseña, usuario.empleadoCliente, usuario.intentos, usuario.estado
                );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se agregó el usuario correctamente a la base de datos.", "Exito");
            }
        }
        public static void Modificar(Usuario usuario)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Usuario>("sp_ModificarUsuario",
                    new
                    {
                        @nombreUsuario = usuario.nombreUsuario,
                        @contraseña = usuario.contraseña,
                        @empleadoCliente = usuario.empleadoCliente,
                        @intentos = usuario.intentos,
                        @estado = usuario.estado
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE Usuario SET nombreUsuario = '{0}', contraseña = '{1}', empleadoCliente = '{2}', intentos = '{3}', estado = '{4}')" +
                    "WHERE nombreUsuario = {0} if exists;",
                    usuario.nombreUsuario, usuario.contraseña, usuario.empleadoCliente, usuario.intentos, usuario.estado
                );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se modificó el usuario correctamente a la base de datos.", "Exito");
            }            
        }
        public static void Eliminar(string nombreUsuario)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<Usuario>("sp_EliminarUsuario", new { @nombreUsuario = nombreUsuario }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM Usuario WHERE nombreUsuario = {0} if exists;",
                    nombreUsuario
                    );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se eliminó el usuario correctamente de la base de datos.", "Exito");
            }
        }

        //FORM PROCESOS
        public static bool LogIn(string usuario, string contraseña, int empleadoCliente)
        {
            bool log = false;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                try
                {
                    Usuario vusuario = Buscar(usuario);
                    //List<Usuario> usuarios = data.ToList();
                    if (vusuario.intentos < 3)
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
                    Modificar(vusuario);
                }
                catch (Exception except)
                {
                    MessageBox.Show("Error: " + except);
                }
                
                ConexionDB_MAD.desconectar();
            }
            else
            {
                try
                {
                    Usuario vusuario = Buscar(usuario);

                }
                catch(Exception except)
                {

                }
            }
            return log;
        }
    } 
}
