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
    class Consumo
    {
        public int numeroMedidor { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
        public float lecturaAnterior { get; set; }
        public float lecturaActual { get; set; }
        public int numeroContrato { get; set; }

        public Consumo()
        {

        }
        public Consumo(Consumo consumo)
        {
            this.numeroMedidor = consumo.numeroMedidor;
            this.anio = consumo.anio;
            this.mes = consumo.mes;
            this.lecturaAnterior = consumo.lecturaAnterior;
            this.lecturaActual = consumo.lecturaActual;
            this.numeroContrato = consumo.numeroContrato;
        }
        public Consumo(int numeroMedidor, int anio, int mes, float lecturaAnterior, float lecturaActual, int numeroContrato)
        {
            this.numeroMedidor = numeroMedidor;
            this.anio = anio;
            this.mes = mes;
            this.lecturaAnterior = lecturaAnterior;
            this.lecturaActual = lecturaActual;
            this.numeroContrato = numeroContrato;
        }

        //DB QUERY 
        public static Consumo Buscar(int numeroMedidor, int anio, int mes)
        {
            Consumo temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Consumo>("sp_BuscarConsumo",
                    new
                    {
                        @numeroMedidor = numeroMedidor,
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
                "SELECT numeroMedidor, anio, mes, lecturaAnterior, lecturaActual, numeroContrato " +
                "FROM Consumo WHERE numeroMedidor = {0} AND anio = {1} AND mes = {2} allow filtering;",
                numeroMedidor, anio, mes);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Consumo> data = mapper.Fetch<Consumo>(query);
                List<Consumo> lista = data.ToList();
                if (lista.Count() > 0)
                {
                    temp = lista.ToList()[0];
                }
            }
            return temp;
        }
        public static Consumo BuscarPorContrato(int numeroContrato, int anio, int mes)
        {
            Consumo temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Consumo>("sp_BuscarConsumoPorContrato",
                    new
                    {
                        @numeroContrato = numeroContrato,
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
                "SELECT numeroMedidor, anio, mes, lecturaAnterior, lecturaActual, numeroContrato " +
                "FROM Consumo WHERE numeroContrato = {0} AND anio = {1} AND mes = {2} allow filtering;",
                numeroContrato, anio, mes);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Consumo> data = mapper.Fetch<Consumo>(query);
                List<Consumo> lista = data.ToList();
                if (lista.Count() > 0)
                {
                    temp = lista.ToList()[0];
                }
            }
            return temp;
        }

        public static void Agregar(Consumo consumo)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Consumo>("sp_AgregarConsumo",
                    new
                    {
                        @numeroMedidor = consumo.numeroMedidor,
                        @anio = consumo.anio,
                        @mes = consumo.mes,
                        @lecturaActual = consumo.lecturaActual,
                        @lecturaAnterior = consumo.lecturaAnterior,
                        @numeroContrato = consumo.numeroContrato
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO Consumo(numeroMedidor, anio, mes, lecturaAnterior, lecturaActual, numeroContrato) " +
                    "VALUES({0}, {1}, {2}, {3}, {4}, {5}); ",
                    consumo.numeroMedidor, consumo.anio, consumo.mes, consumo.lecturaAnterior, consumo.lecturaActual, consumo.numeroContrato
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }
        public static void Modificar(Consumo consumo)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Consumo>("sp_ModificarConsumo",
                    new
                    {
                        @numeroMedidor = consumo.numeroMedidor,
                        @anio = consumo.anio,
                        @mes = consumo.mes,
                        @lecturaActual = consumo.lecturaActual,
                        @lecturaAnterior = consumo.lecturaAnterior,
                        @numeroContrato = consumo.numeroContrato
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                //NO SIRVE PERO NO SE NECESITA
                //string query = string.Format(
                //    "UPDATE Consumo SET a = {1}, anio = {2} " +
                //    "WHERE numeroZona = {0} if exists;",
                //    zona.numeroZona, zona.nombre
                //);
                //ConexionDB_AAVD.executeQuery(query);
            }
        }
        public static void Eliminar(int numeroMedidor, int anio, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Consumo>("sp_EliminarConsumo",
                    new
                    {
                        @numeroMedidor = numeroMedidor,
                        @anio = anio,
                        @mes = mes
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM Consumo WHERE numeroMedidor = {0} AND anio = {1} AND mes = {2} if exists;",
                    numeroMedidor, anio, mes
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

                var data = ConexionDB_MAD.db.Query<Consumo>("sp_ConsultarConsumos",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT numeroMedidor, anio, mes, lecturaAnterior, lecturaActual, numeroContrato " +
                "FROM Consumo allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Consumo> data = mapper.Fetch<Consumo>(query);
                dg.DataSource = data.ToList();
            }
        }
    }
}
