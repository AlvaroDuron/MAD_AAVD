using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD.Clases
{
    class Consumo
    {
        public int año { get; set; }
        public int mes { get; set; }
        public int numeroMedidor { get; set; }
        public float lecturaActual { get; set; }
        public float lecturaAnterior { get; set; }
        public float consumo { get; set; }

        public Consumo()
        {

        }
        public Consumo(int año, int mes, int numeroMedidor, float lecturaActual, float lecturaAnterior, float consumo)
        {
            this.año = año;
            this.mes = mes;
            this.numeroMedidor = numeroMedidor;
            this.lecturaActual = lecturaActual;
            this.lecturaAnterior = lecturaAnterior;
            this.consumo = consumo;
        }

        //DB QUERY 
        public static Consumo Buscar(int año, int mes, int numeroMedidor)
        {
            Consumo temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Consumo>("sp_BuscarConsumo",
                    new
                    {
                        @año = año,
                        @mes = mes,
                        @numeroMedidor = numeroMedidor
                    },
                    commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
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
                        @año = consumo.año,
                        @mes = consumo.mes,
                        @numeroMedidor = consumo.numeroMedidor,
                        @lecturaActual = consumo.lecturaActual,
                        @lecturaAnterior = consumo.lecturaAnterior,
                        @consumo = consumo.consumo
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
                        @año = consumo.año,
                        @mes = consumo.mes,
                        @numeroMedidor = consumo.numeroMedidor,
                        @lecturaActual = consumo.lecturaActual,
                        @lecturaAnterior = consumo.lecturaAnterior,
                        @consumo = consumo.consumo
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }
        public static void Eliminar(int año, int mes, int numeroMedidor)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Consumo>("sp_EliminarConsumo",
                    new
                    {
                        @año = año,
                        @mes = mes,
                        @numeroMedidor = numeroMedidor
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

                var data = ConexionDB_MAD.db.Query<Consumo>("sp_ConsultarConsumo",
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
