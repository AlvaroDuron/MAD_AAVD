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
    class Recibo
    {
        public string nombreUsuario { get; set; }
        //public string direccion { get; set; } viene de contrato
        public int numeroContrato { get; set; }
        public int año { get; set; }
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
        public Recibo(string nombreUsuario, int numeroContrato, int año, int mes, string expedicion, int numeroZona, float consumo, float subtotal1, float subtotal2, float subtotal3, float total, DateTime vencimiento, bool pagado)
        {
            this.nombreUsuario = nombreUsuario;
            this.numeroContrato = numeroContrato;
            this.año = año;
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
        public static Recibo Buscar(int numeroContrato, int año, int mes)
        {
            Recibo temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Recibo>("sp_BuscarRecibo",
                    new
                    {
                        @numeroContrato = numeroContrato,
                        @año = año,
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
                        @año = recibo.año,
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
                        @año = recibo.año,
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

            }
        }

        public static void Eliminar(int numeroContrato, int año, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Consumo>("sp_EliminarRecibo",
                    new
                    {
                        @numeroContrato = numeroContrato,
                        @año = año,
                        @mes = mes
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {


            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg, int año, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Recibo>("sp_ConsultarRecibos",
                    new 
                    { 
                        @año = año,
                        @mes = mes
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {

            }
        }
        public static void LlenarDG(DataGridView dg, string tipoServicio, int año, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Recibo>("sp_ConsultarRecibosPorServicio",
                    new 
                    {
                        @tipoServicio = tipoServicio,
                        @año = año,
                        @mes = mes
                    },
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
