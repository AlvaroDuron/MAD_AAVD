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
    class Tarifa
    {
        public int año { get; set; }
        public int mes { get; set; }
        public int zona { get; set; }
        public float cuotaFija { get; set; }
        public float rango1 { get; set; }
        public float rango2 { get; set; }
        public float rango3 { get; set; }

        public Tarifa()
        {

        }
        public Tarifa(int año, int mes, int zona, float cuotaFija, float rango1, float rango2, float rango3)
        {
            this.año = año;
            this.mes = mes;
            this.zona = zona;
            this.cuotaFija = cuotaFija;
            this.rango1 = rango1;
            this.rango2 = rango2;
            this.rango3 = rango3;
        }

        //DB QUERY 
        public static Tarifa Buscar(int año, int mes, int zona)
        {
            Tarifa temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Tarifa>("sp_BuscarTarifa", 
                    new 
                    { 
                        @año = año,
                        @mes = mes,
                        @zona = zona
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
        public static void Agregar(Tarifa tarifa)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Zona>("sp_AgregarTarifa",
                    new
                    {
                        @año = tarifa.año,
                        @mes = tarifa.mes,
                        @zona = tarifa.zona,
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
                        @año = tarifa.año,
                        @mes = tarifa.mes,
                        @zona = tarifa.zona,
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
        public static void Eliminar(int año, int mes, int zona)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Tarifa>("sp_EliminarTarifa",
                    new
                    {
                        @año = año,
                        @mes = mes,
                        @zona = zona
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

                var data = ConexionDB_MAD.db.Query<Zona>("sp_ConsultarTarifas",
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
