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
    class Tarifa
    {
        public int numeroZona { get; set; }
        public string tipoServicio { get; set; }
        public int año { get; set; }
        public int mes { get; set; }
        public float cuotaFija { get; set; }
        public float rango1 { get; set; }
        public float rango2 { get; set; }
        public float rango3 { get; set; }

        public Tarifa()
        {

        }
        public Tarifa(int numeroZona, string tipoServicio, int año, int mes, float cuotaFija, float rango1, float rango2, float rango3)
        {
            this.numeroZona = numeroZona;
            this.tipoServicio = tipoServicio;
            this.año = año;
            this.mes = mes;
            this.cuotaFija = cuotaFija;
            this.rango1 = rango1;
            this.rango2 = rango2;
            this.rango3 = rango3;
        }

        //DB QUERY 
        public static Tarifa Buscar(int numeroZona, string tipoServicio, int año, int mes)
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
        public static void Agregar(Tarifa tarifa)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Zona>("sp_AgregarTarifa",
                    new
                    {
                        @numeroZona = tarifa.numeroZona,
                        @tipoServicio = tarifa.tipoServicio,
                        @año = tarifa.año,
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
                        @año = tarifa.año,
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

            }
        }
        public static void Eliminar(int numeroZona, string tipoServicio, int año, int mes)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Tarifa>("sp_EliminarTarifa",
                    new
                    {
                        @numeroZona = numeroZona,
                        @tipoServicio = tipoServicio,
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

                var data = ConexionDB_MAD.db.Query<Tarifa>("sp_ConsultarTarifas",
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
