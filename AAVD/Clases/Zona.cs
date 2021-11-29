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
    public class Zona
    {
        public int numeroZona { get; set; }
        public string nombre { get; set; }
        public Zona()
        {

        }

        public Zona(int numeroZona, string nombre)
        {
            this.numeroZona = numeroZona;
            this.nombre = nombre;
        }

        //BD QUERY
        public static Zona Buscar(int numeroZona)
        {
            Zona temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Zona>("sp_BuscarZona", new { @numeroZona = numeroZona }, commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT numeroZona, nombre" +
                "FROM Zona WHERE numeroZona = '{0}' allow filtering;",
                numeroZona);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Zona> data = mapper.Fetch<Zona>(query);
                temp = data.ToList()[0];
            }
            return temp;
        }
        public static Zona BuscarPorNombre(string nombre)
        {
            Zona temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Zona>("sp_BuscarZonaPorNombre", new { @nombre = nombre }, commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT numeroZona, nombre" +
                "FROM Zona WHERE nombre = '{0}' allow filtering;",
                nombre);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Zona> data = mapper.Fetch<Zona>(query);
                temp = data.ToList()[0];
            }
            return temp;
        }
        public static void Agregar(Zona zona)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Zona>("sp_AgregarZona",
                    new 
                    { 
                        @numeroZona = zona.numeroZona,
                        @nombre = zona.nombre
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO Zona(numeroZona, nombre)" +
                    "VALUES('{0}', '{1}'); ",
                    zona.numeroZona, zona.nombre
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }
        public static void Modificar(Zona zona)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Zona>("sp_ModificarZona",
                    new
                    {
                        @numeroZona = zona.numeroZona,
                        @nombre = zona.nombre
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE Zona SET nombre = '{1}'" +
                    "WHERE numeroZona = {0} if exists;",
                    zona.numeroZona, zona.nombre
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }
        public static void Eliminar(int numeroZona)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Zona>("sp_EliminarZona",
                    new
                    {
                        @numeroZona = numeroZona
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM Zona WHERE numeroZona = {0} if exists;",
                    numeroZona
                    );
                ConexionDB_AAVD.executeQuery(query);
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Zona>("sp_ConsultarZonas",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT numeroZona, nombre" +
                "FROM Zona allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Zona> data = mapper.Fetch<Zona>(query);
                dg.DataSource = data.ToList();
            }
        }

        public static void LlenarCB(ComboBox cb)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<string>("sp_ConsultarZonasPorNombre",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                cb.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT nombre" +
                "FROM Zona allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Zona> data = mapper.Fetch<Zona>(query);
                cb.DataSource = data.ToList();
            }
        }
    }
}
