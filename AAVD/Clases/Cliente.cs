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
    public class ClienteFisico
    {
        public string curp { get; set; }
        public string nombreUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime nacimiento { get; set; }
        public char genero { get; set; }
        public string email { get; set; }
        public DateTime fechaAltaMod { get; set; }

        public ClienteFisico()
        {

        }
        public ClienteFisico(string curp, string nombreUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime nacimiento, char genero, string email, DateTime fechaAltaMod)
        {
            this.curp = curp;
            this.nombreUsuario = nombreUsuario;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.email = email;
            this.nacimiento = nacimiento;
            this.genero = genero;
            this.fechaAltaMod = fechaAltaMod;
        }

        //BD QUERY
        public static ClienteFisico Buscar(string curp)
        {
            ClienteFisico temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<ClienteFisico>("sp_BuscarClienteFisico", new { @curp = curp }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, email, curp, nacimiento, genero, fechaAltaMod" +
                "FROM ClienteFisico WHERE curp = '{0}' allow filtering;",
                curp);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<ClienteFisico> data = mapper.Fetch<ClienteFisico>(query);
                temp = data.ToList()[0];
            }
            return temp;
        }
        public static void Agregar(ClienteFisico cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<ClienteFisico>("sp_AgregarClienteFisico",
                    new
                    {
                        @curp = cliente.curp,
                        @nombreUsuario = cliente.nombreUsuario,
                        @nombre = cliente.nombre,
                        @apellidoPaterno = cliente.apellidoPaterno,
                        @apellidoMaterno = cliente.apellidoMaterno,
                        @nacimiento = cliente.nacimiento,
                        @genero = cliente.genero,
                        @email = cliente.email
                        //@fechaAltaMod = cliente.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO ClieneteFisico(curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, email, nacimiento, genero, fechaAltaMod)" +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', toUnixTimestamp(now())); ",
                    cliente.curp, cliente.nombreUsuario, cliente.nombre, cliente.apellidoPaterno, cliente.apellidoMaterno, cliente.email, cliente.nacimiento, cliente.genero
                );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se agregó al cliente correctamente a la base de datos.", "Exito");
            }
        }
        public static void Modificar(ClienteFisico cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<ClienteFisico>("sp_ModificarClienteFisico",
                    new
                    {
                        @curp = cliente.curp,
                        @nombreUsuario = cliente.nombreUsuario,
                        @nombre = cliente.nombre,
                        @apellidoPaterno = cliente.apellidoPaterno,
                        @apellidoMaterno = cliente.apellidoMaterno,
                        @nacimiento = cliente.nacimiento,
                        @genero = cliente.genero,
                        @email = cliente.email
                        //@fechaAltaMod = cliente.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE ClienteFisico SET nombreUsuario = '{1}', nombre = '{2}', apellidoPaterno = '{3}', apellidoMaterno = '{4}', email = '{5}', curp = '{0}', nacimiento = '{6}', genero = '{7}', fechaAltaMod = toUnixTimestamp(now())" +
                    "WHERE curp = {0} if exists;",
                    cliente.curp, cliente.nombreUsuario, cliente.nombre, cliente.apellidoPaterno, cliente.apellidoMaterno, cliente.email, cliente.nacimiento, cliente.genero
                );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se modificó el cliente correctamente a la base de datos.", "Exito");
            }
        }
        public static void Eliminar(string curp)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<ClienteFisico>("sp_EliminarClienteFisico", new { @curp = curp }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM ClienteFisico WHERE curp = {0} if exists;",
                    curp
                    );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se eliminó el cliente correctamente a la base de datos.", "Exito");
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<ClienteFisico>("sp_ConsultarClientesFisicos",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT idCliente, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, email, curp, nacimiento, genero, fechaAltaMod" +
                "FROM Empleado allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<ClienteFisico> data = mapper.Fetch<ClienteFisico>(query);
                dg.DataSource = data.ToList();
            }
        }
    }

    class ClienteMoral
    {
        public string rfc { get; set; }
        public string nombreUsuario { get; set; }
        public string nombre { get; set; }
        public DateTime constitucion { get; set; }
        public string email { get; set; }
        public DateTime fechaAltaMod { get; set; }

        public ClienteMoral()
        {

        }
        public ClienteMoral(string rfc, string nombreUsuario, string nombre, DateTime constitucion, string email, DateTime fechaAltaMod)
        {
            this.rfc = rfc;
            this.nombreUsuario = nombreUsuario;
            this.nombre = nombre;
            this.constitucion = constitucion;
            this.email = email;
            this.fechaAltaMod = fechaAltaMod;
        }

        //BD QUERY
        public static ClienteMoral Buscar(string rfc)
        {
            ClienteMoral temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<ClienteMoral>("sp_BuscarClienteMoral", new { @rfc = rfc }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
            }
            else
            {
                //string query = string.Format(
                //"SELECT idCliente, nombreUsuario, nombre, email, rfc, constitucion, fechaAltaMod" +
                //"FROM ClienteMoral WHERE idCliente = '{0}' allow filtering;",
                //idCliente);

                //IMapper mapper = ConexionDB_AAVD.conexion();
                //IEnumerable<ClienteMoral> data = mapper.Fetch<ClienteMoral>(query);
                //temp = data.ToList()[0];
            }
            return temp;
        }
        public static void Agregar(ClienteMoral cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<ClienteMoral>("sp_AgregarClienteMoral",
                    new
                    {
                        @rfc = cliente.rfc,
                        @nombreUsuario = cliente.nombreUsuario,
                        @nombre = cliente.nombre,
                        @constitucion = cliente.constitucion,
                        @email = cliente.email
                        //@fechaAltaMod = cliente.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO ClieneteMoral(idCliente, nombreUsuario, nombre, email, rfc, constitucion, fechaAltaMod)" +
                    "VALUES(uuid(), '{0}', '{1}', '{2}', '{3}', '{4}', toUnixTimestamp(now())); ",
                    cliente.nombreUsuario, cliente.nombre, cliente.email, cliente.rfc, cliente.constitucion
                );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se agregó al cliente correctamente a la base de datos.", "Exito");
            }
        }
        public static void Modificar(ClienteMoral cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<ClienteMoral>("sp_ModificarClienteMoral",
                    new
                    {
                        @rfc = cliente.rfc,
                        @nombreUsuario = cliente.nombreUsuario,
                        @nombre = cliente.nombre,
                        @constitucion = cliente.constitucion,
                        @email = cliente.email
                        //@fechaAltaMod = cliente.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                //string query = string.Format(
                //    "UPDATE ClienteMoral SET nombreUsuario = '{0}', nombre = '{1}', email = '{2}', rfc = '{3}', constitucion = '{4}', fechaAltaMod = toUnixTimestamp(now())" +
                //    "WHERE idCliente = {8} if exists;",
                //    cliente.nombreUsuario, cliente.nombre, cliente.email, cliente.rfc, cliente.constitucion, cliente.idCliente
                //);
                //ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se modificó el cliente correctamente a la base de datos.", "Exito");
            }
        }
        public static void Eliminar(string rfc)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<ClienteMoral>("sp_EliminarClienteMoral", new { @rfc = rfc }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM ClienteFisico WHERE idCliente = {0} if exists;",
                    rfc
                    );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se eliminó el cliente correctamente a la base de datos.", "Exito");
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<ClienteMoral>("sp_ConsultarClientesMorales",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                
            }
        }
    }
}
