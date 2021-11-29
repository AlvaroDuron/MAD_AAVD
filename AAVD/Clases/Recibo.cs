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
    class Recibo
    {
        public string nombreUsuario { get; set; }
        //public string direccion { get; set; } viene de contrato
        public int numeroContrato { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
        public string expedicion { get; set; }
        public int numeroZona { get; set; }
        //public char categoria { get; set; } viene de contrato
        //public string tipoServicio { get; set; } viene de contrato
        //public int numeroMedidor { get; set; } viene de contrato
        //public float consumo { get; set; } se arma con año, mes y numero de medidor del contrato
        //public int mesesAdeudo { get; set; } viene de recibos pasados
        public float consumo { get; set; }
        public float subtotal1 { get; set; }
        public float subtotal2 { get; set; }
        public float subtotal3 { get; set; }
        public float total { get; set; }
        public DateTime vencimiento { get; set; }
        public bool pagado { get; set; }

        public Recibo()
        {

        }
        public Recibo(string nombreUsuario, int numeroContrato, int anio, int mes, string expedicion, int numeroZona, float consumo, float subtotal1, float subtotal2, float subtotal3, float total, DateTime vencimiento, bool pagado)
        {
            this.nombreUsuario = nombreUsuario;
            this.numeroContrato = numeroContrato;
            this.anio = anio;
            this.mes = mes;
            this.expedicion = expedicion;
            this.numeroZona = numeroZona;
            this.consumo = consumo;
            this.subtotal1 = subtotal1;
            this.subtotal2 = subtotal2;
            this.subtotal3 = subtotal3;
            this.total = total;
            this.vencimiento = vencimiento;
            this.pagado = pagado;
        }

        //DB QUERY 
        public static Recibo Buscar(int numeroContrato, int anio, int mes)
        {
            Recibo temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Recibo>("sp_BuscarRecibo",
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
                "SELECT nombreUsuario, numeroContrato, anio, mes, expedicion, numeroZona, consumo, subtotal1, subtotal2, subtotal3, total, vencimiento, pagado" +
                "FROM Recibo WHERE numeroContrato = '{0}' AND anio = '{1}' AND mes = '{2}' allow filtering;",
                numeroContrato, anio, mes);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Recibo> data = mapper.Fetch<Recibo>(query);
                List<Recibo> lista = data.ToList();
                if (lista.Count() > 0)
                {
                    temp = lista.ToList()[0];
                }
            }
            return temp;
        }

        public static void Agregar(Recibo recibo)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Recibo>("sp_AgregarRecibo",
                    new
                    {
                        @nombreUsuario = recibo.nombreUsuario,
                        @numeroContrato = recibo.numeroContrato,
                        @año = recibo.anio,
                        @mes = recibo.mes,
                        @expedicion = recibo.expedicion,
                        @numeroZona = recibo.numeroZona,
                        @consumo = recibo.consumo,
                        @subtotal1 = recibo.subtotal1,
                        @subtotal2 = recibo.subtotal2,
                        @subtotal3 = recibo.subtotal3,
                        @total = recibo.total,
                        @vencimiento = recibo.vencimiento,
                        @pagado = recibo.pagado
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO Recibo(nombreUsuario, numeroContrato, anio, mes, expedicion, numeroZona, consumo, subtotal1, subtotal2, subtotal3, total, vencimiento, pagado)" +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}'); ",
                    recibo.nombreUsuario, recibo.numeroContrato, recibo.anio, recibo.mes, recibo.expedicion, recibo.numeroZona, recibo.consumo, recibo.subtotal1, recibo.subtotal2, recibo.subtotal3, recibo.total, recibo.vencimiento, recibo.pagado
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }

        public static void Modificar(Recibo recibo)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Recibo>("sp_ModificarRecibo",
                    new
                    {
                        @nombreUsuario = recibo.nombreUsuario,
                        @numeroContrato = recibo.numeroContrato,
                        @año = recibo.anio,
                        @mes = recibo.mes,
                        @expedicion = recibo.expedicion,
                        @numeroZona = recibo.numeroZona,
                        @consumo = recibo.consumo,
                        @subtotal1 = recibo.subtotal1,
                        @subtotal2 = recibo.subtotal2,
                        @subtotal3 = recibo.subtotal3,
                        @total = recibo.total,
                        @vencimiento = recibo.vencimiento,
                        @pagado = recibo.pagado
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                //NO TERMINADA PERO NO NECESARIA
                //string query = string.Format(
                //    "UPDATE Recibo SET contrasena = '{1}', empleadoCliente = '{2}', intentos = '{3}', estado = '{4}')" +
                //    "WHERE numeroContrato = {0} AND anio = {1} AND mes = {2} if exists;",
                //    usuario.nombreUsuario, usuario.contrasena, usuario.empleadoCliente, usuario.intentos, usuario.estado
                //);
                //ConexionDB_AAVD.executeQuery(query);
            }
        }

        public static void Eliminar(int numeroContrato, int anio, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Consumo>("sp_EliminarRecibo",
                    new
                    {
                        @numeroContrato = numeroContrato,
                        @anio = anio,
                        @mes = mes
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM Recibo WHERE numeroContrato = {0} AND anio = {1} AND mes = {2} if exists;",
                    numeroContrato, anio, mes
                    );
                ConexionDB_AAVD.executeQuery(query);
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg, int anio, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Recibo>("sp_ConsultarRecibos",
                    new 
                    {
                        @anio = anio,
                        @mes = mes
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT nombreUsuario, numeroContrato, anio, mes, expedicion, numeroZona, consumo, subtotal1, subtotal2, subtotal3, total, vencimiento, pagado " +
                "FROM Recibo WHERE anio = {0} AND mes = {1} allow filtering;",
                anio, mes
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Recibo> data = mapper.Fetch<Recibo>(query);
                dg.DataSource = data.ToList();
            }
        }
        public static void LlenarDG(DataGridView dg, string tipoServicio, int anio, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Recibo>("sp_ConsultarRecibosPorServicio",
                    new 
                    {
                        @tipoServicio = tipoServicio,
                        @anio = anio,
                        @mes = mes
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                IMapper mapper = ConexionDB_AAVD.conexion();

                string query1 = string.Format(
                "SELECT numeroContrato " +
                "FROM Contrato WHERE tipoServicio = '{0}' allow filtering;",
                tipoServicio
                );
                IEnumerable<string> data1 = mapper.Fetch<string>(query1);
                List<string> contratos = data1.ToList();

                List<Recibo> recibos = new List<Recibo>();
                foreach (string contrato in contratos)
                {
                    string query2 = string.Format(
                    "SELECT nombreUsuario, numeroContrato, anio, mes, expedicion, numeroZona, consumo, subtotal1, subtotal2, subtotal3, total, vencimiento, pagado " +
                    "FROM Recibo WHERE numeroContrato = '{0}' AND anio = {1} AND mes = {2} allow filtering;",
                    contrato, anio, mes
                    );
                    IEnumerable<Recibo> data2 = mapper.Fetch<Recibo>(query2);
                    if (data2.Count() > 0)
                    {
                        recibos.Add(data2.ToList()[0]);
                    }
                }
                dg.DataSource = recibos.ToList();
            }
        }
    }
}
