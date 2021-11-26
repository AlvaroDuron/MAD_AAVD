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
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string nombreUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime nacimiento { get; set; }
        public char genero { get; set; }
        public int numeroExterior { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public DateTime fechaAltaMod { get; set; }

        public Empleado()
        {

        }
        public Empleado(int idEmpleado, string nombreUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime nacimiento, char genero, int numeroExterior, string calle, string colonia, string municipio, DateTime fechaAltaMod)
        {
            this.idEmpleado = idEmpleado;
            this.nombreUsuario = nombreUsuario;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.nacimiento = nacimiento;
            this.genero = genero;
            this.numeroExterior = numeroExterior;
            this.calle = calle;
            this.colonia = colonia;
            this.municipio = municipio;
            this.fechaAltaMod = fechaAltaMod;
        }

        //BD QUERY
        public static Empleado Buscar(int idEmpleado)
        {
            Empleado temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Empleado>("sp_BuscarEmpleado", new { @idEmpleado = idEmpleado }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT idEmpleado, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, numeroExterior, calle, colonia, municipio, genero, fechaAltaMod" +
                "FROM Empleado WHERE idEmpleado = '{0}' allow filtering;",
                idEmpleado);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Empleado> data = mapper.Fetch<Empleado>(query);
                temp = data.ToList()[0];
            }
            return temp;
        }
        public static void Agregar(Empleado empleado)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Empleado>("sp_AgregarEmpleado",
                    new
                    {
                        //@idEmpleado = empleado.idEmpleado,
                        @nombreUsuario = empleado.nombreUsuario,
                        @nombre = empleado.nombre,
                        @apellidoPaterno = empleado.apellidoPaterno,
                        @apellidoMaterno = empleado.apellidoMaterno,
                        @nacimiento = empleado.nacimiento,
                        @genero = empleado.genero,
                        @numeroExterior = empleado.numeroExterior,
                        @calle = empleado.calle,
                        @colonia = empleado.colonia,
                        @municipio = empleado.municipio
                        //@fechaAltaMod = empleado.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO Empleado(idEmpleado, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, numeroExterior, calle, colonia, municipio, genero, fechaAltaMod)" +
                    "VALUES(uuid(), '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', toUnixTimestamp(now())); ",
                    empleado.nombreUsuario, empleado.nombre, empleado.apellidoPaterno, empleado.apellidoMaterno, empleado.nacimiento, empleado.numeroExterior, empleado.calle, empleado.colonia, empleado.municipio, empleado.genero
                );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se agregó el empleado correctamente a la base de datos.", "Exito");
            }
        }
        public static void Modificar(Empleado empleado)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Empleado>("sp_ModificarEmpleado",
                    new
                    {
                        @idEmpleado = empleado.idEmpleado,
                        @nombreUsuario = empleado.nombreUsuario,
                        @nombre = empleado.nombre,
                        @apellidoPaterno = empleado.apellidoPaterno,
                        @apellidoMaterno = empleado.apellidoMaterno,
                        @nacimiento = empleado.nacimiento,
                        @genero = empleado.genero,
                        @numeroExterior = empleado.numeroExterior,
                        @calle = empleado.calle,
                        @colonia = empleado.colonia,
                        @municipio = empleado.municipio
                        //@fechaAltaMod = empleado.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE Empleado SET nombreUsuario = '{0}', nombre = '{1}', apellidoPaterno = '{2}', apellidoMaterno = '{3}', nacimiento = '{4}', numeroExterior = '{5}', calle = '{6}', colonia = '{7}', municipio = '{8}', genero = '{9}', fechaAltaMod = toUnixTimestamp(now())" +
                    "WHERE idEmpleado = {10} if exists;",
                    empleado.nombreUsuario, empleado.nombre, empleado.apellidoPaterno, empleado.apellidoMaterno, empleado.nacimiento, empleado.numeroExterior, empleado.calle, empleado.colonia, empleado.municipio, empleado.genero, empleado.idEmpleado
                );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se modificó el empleado correctamente a la base de datos.", "Exito");
            }
        }
        public static void Eliminar(int idEmpleado)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<Empleado>("sp_EliminarEmpleado", new { @idEmpleado = idEmpleado }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM Empleado WHERE idEmpleado = {0} if exists;",
                    idEmpleado
                    );
                ConexionDB_AAVD.executeQuery(query);
                MessageBox.Show("Se eliminó el empleado correctamente a la base de datos.", "Exito");
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Empleado>("sp_ConsultarEmpleados",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT idEmpleado, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, numeroExterior, calle, colonia, municipio, genero, fechaAltaMod" +
                "FROM Empleado allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Empleado> data = mapper.Fetch<Empleado>(query);
                dg.DataSource = data.ToList();
            }
        }

        public static void LlenarDGBan(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Empleado>("sp_ConsultarEmpleadosBaneados", new { }, commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {

            }
        }
    }
}
