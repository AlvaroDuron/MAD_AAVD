using Dapper;
using Cassandra;
using Cassandra.Mapping;
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
        public string contrasena { get; set; }
        public int empleadoCliente { get; set; }
        public int intentos { get; set; }
        public int estado { get; set; }

        public Usuario()
        {

        }
        public Usuario(string nombreUsuario, string contrasena, byte empleado, byte intentos, byte estado)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
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
                if(data.Count() != 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT nombreUsuario, contrasena, empleadoCliente, intentos, estado " +
                "FROM Usuario WHERE nombreUsuario = '{0}' allow filtering;",
                nombreUsuario);
                
                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Usuario> data = mapper.Fetch<Usuario>(query);
                List<Usuario> usuarios = data.ToList();
                if (usuarios.Count() > 0)
                {
                    temp = usuarios.ToList()[0];
                }
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
                        @contraseña = usuario.contrasena,
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
                    "INSERT INTO Usuario(nombreUsuario, contrasena, empleadoCliente, intentos, estado) " +
                    "VALUES('{0}', '{1}', {2}, {3}, {4}); ",
                    usuario.nombreUsuario, usuario.contrasena, usuario.empleadoCliente, usuario.intentos, usuario.estado
                );
                ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se agregó el usuario correctamente a la base de datos.", "Exito");
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
                        @contrasena = usuario.contrasena,
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
                    "UPDATE Usuario SET contrasena = '{1}', empleadoCliente = {2}, intentos = {3}, estado = {4} " +
                    "WHERE nombreUsuario = '{0}' if exists;",
                    usuario.nombreUsuario, usuario.contrasena, usuario.empleadoCliente, usuario.intentos, usuario.estado
                );
                ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se modificó el usuario correctamente a la base de datos.", "Exito");
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
                    "DELETE FROM Usuario WHERE nombreUsuario = '{0}' if exists;",
                    nombreUsuario
                    );
                ConexionDB_AAVD.executeQuery(query);
            }
        }

        //FORM PROCESOS
        public static void LlenarCB(ComboBox cb)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<string>("sp_ConsultarUsuariosPorNombre",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                cb.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT nombreUsuario, contrasena, empleadoCliente, intentos, estado " +
                "FROM Usuario WHERE empleadoCliente = 0 allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Usuario> data = mapper.Fetch<Usuario>(query);
                List<Usuario> servicios = data.ToList();
                cb.Items.Clear();
                foreach (Usuario servicio in servicios)
                {
                    cb.Items.Add(servicio.nombreUsuario);
                }
            }
        }

        public static bool LogIn(string usuario, string contrasena, int empleadoCliente)
        {
            bool log = false;
            try
            {
                Usuario vusuario = Buscar(usuario);
                if (vusuario != null)
                {
                    if (vusuario.empleadoCliente == empleadoCliente)
                    {
                        if (vusuario.intentos < 3)
                        {
                            if (vusuario.contrasena == contrasena)
                            {
                                //login
                                vusuario.intentos = 0;
                                Program.session = vusuario;
                                log = true;
                            }
                            else
                            {
                                vusuario.intentos++;
                                MessageBox.Show("Contraseña incorrecta.");
                                if (vusuario.intentos == 3)
                                {
                                    vusuario.estado = 2;
                                    MessageBox.Show("La cuenta se ha suspendido.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cuenta está suspendida por el momento.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esa cuenta no coincide.");
                    }
                    Modificar(vusuario);
                }
                else
                {
                    MessageBox.Show("Ese usuario no existe.");
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error: " + except);
            }
            return log;
        }
    } 
}
