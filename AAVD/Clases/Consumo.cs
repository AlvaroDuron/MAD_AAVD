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
    class Consumo
    {
        public int numeroMedidor { get; set; }
        public int año { get; set; }
        public int mes { get; set; }
        public float lecturaAnterior { get; set; }
        public float lecturaActual { get; set; }
        public int numeroContrato { get; set; }

        public Consumo()
        {

        }
        public Consumo(int numeroMedidor, int año, int mes, float lecturaActual, float lecturaAnterior, int numeroContrato)
        {
            this.numeroMedidor = numeroMedidor;
            this.año = año;
            this.mes = mes;
            this.lecturaAnterior = lecturaAnterior;
            this.lecturaActual = lecturaActual;
            this.numeroContrato = numeroContrato;
        }

        //DB QUERY 
        public static Consumo Buscar(int numeroMedidor, int año, int mes)
        {
            Consumo temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Consumo>("sp_BuscarConsumo",
                    new
                    {
                        @numeroMedidor = numeroMedidor,
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
        public static Consumo BuscarPorContrato(int numeroContrato, int año, int mes)
        {
            Consumo temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Consumo>("sp_BuscarConsumoPorContrato",
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

        public static void Agregar(Consumo consumo)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Consumo>("sp_AgregarConsumo",
                    new
                    {
                        @numeroMedidor = consumo.numeroMedidor,
                        @año = consumo.año,
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
                        @año = consumo.año,
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

            }
        }
        public static void Eliminar(int numeroMedidor, int año, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Consumo>("sp_EliminarConsumo",
                    new
                    {
                        @numeroMedidor = numeroMedidor,
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

            }
        }
    }
}
