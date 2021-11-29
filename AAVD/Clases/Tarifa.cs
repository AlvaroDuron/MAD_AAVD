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
    class Tarifa
    {
        public int numeroZona { get; set; }
        public string tipoServicio { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
        public float cuotaFija { get; set; }
        public float rango1 { get; set; }
        public float rango2 { get; set; }
        public float rango3 { get; set; }

        public Tarifa()
        {

        }
        public Tarifa(int numeroZona, string tipoServicio, int anio, int mes, float cuotaFija, float rango1, float rango2, float rango3)
        {
            this.numeroZona = numeroZona;
            this.tipoServicio = tipoServicio;
            this.anio = anio;
            this.mes = mes;
            this.cuotaFija = cuotaFija;
            this.rango1 = rango1;
            this.rango2 = rango2;
            this.rango3 = rango3;
        }

        //DB QUERY 
        public static Tarifa Buscar(int numeroZona, string tipoServicio, int anio, int mes)
        {
            Tarifa temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Tarifa>("sp_BuscarTarifa",
                    new
                    {
                        @numeroZona = numeroZona,
                        @tipoServicio = tipoServicio,
                        @anio = anio,
                        @mes = mes
                    },
                    commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT numeroZona, tipoServicio, anio, mes, cuotaFija, rango1, rango2, rango3 " +
                "FROM Tarifa WHERE numeroZona = {0} AND tipoServicio = '{1}' AND anio = {2} AND mes = {3} allow filtering;",
                numeroZona, tipoServicio, anio, mes
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Tarifa> data = mapper.Fetch<Tarifa>(query);
                List<Tarifa> lista = data.ToList();
                if (lista.Count() > 0)
                {
                    temp = lista.ToList()[0];
                }
            }
            return temp;
        }
        public static void Agregar(Tarifa tarifa)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Tarifa>("sp_AgregarTarifa",
                    new
                    {
                        @numeroZona = tarifa.numeroZona,
                        @tipoServicio = tarifa.tipoServicio,
                        @anio = tarifa.anio,
                        @mes = tarifa.mes,
                        @cuotaFija = tarifa.cuotaFija,
                        @rango1 = tarifa.rango1,
                        @rango2 = tarifa.rango2,
                        @rango3 = tarifa.rango3
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO Tarifa(numeroZona, tipoServicio, anio, mes, cuotaFija, rango1, rango2, rango3) " +
                    "VALUES({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}); ",
                    tarifa.numeroZona, tarifa.tipoServicio, tarifa.anio, tarifa.mes, tarifa.cuotaFija, tarifa.rango1, tarifa.rango2, tarifa.rango3
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }
        public static void Modificar(Tarifa tarifa)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Tarifa>("sp_ModificarTarifa",
                    new
                    {
                        @numeroZona = tarifa.numeroZona,
                        @tipoServicio = tarifa.tipoServicio,
                        @anio = tarifa.anio,
                        @mes = tarifa.mes,
                        @cuotaFija = tarifa.cuotaFija,
                        @rango1 = tarifa.rango1,
                        @rango2 = tarifa.rango2,
                        @rango3 = tarifa.rango3
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE Tarifa SET cuotaFija = {4}, rango1 = {5}, rango2 = {6}, rango3 = {7} " +
                    "WHERE numeroZona = {0} AND tipoServicio = '{1}' AND anio = {2} AND mes = {3} if exists;",
                    tarifa.numeroZona, tarifa.tipoServicio, tarifa.anio, tarifa.mes, tarifa.cuotaFija, tarifa.rango1, tarifa.rango2, tarifa.rango3
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }
        public static void Eliminar(int numeroZona, string tipoServicio, int anio, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Tarifa>("sp_EliminarTarifa",
                    new
                    {
                        @numeroZona = numeroZona,
                        @tipoServicio = tipoServicio,
                        @anio = anio,
                        @mes = mes
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM Tarifa WHERE numeroZona = {0} AND tipoServicio = '{1}' AND anio = {2} AND mes = {3} if exists;",
                    numeroZona, tipoServicio, anio, mes
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

                var data = ConexionDB_MAD.db.Query<Tarifa>("sp_ConsultarTarifas",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT numeroZona, tipoServicio, anio, mes, cuotaFija, rango1, rango2, rango3 " +
                "FROM Tarifa allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Tarifa> data = mapper.Fetch<Tarifa>(query);
                dg.DataSource = data.ToList();
            }
        }
    }
}
