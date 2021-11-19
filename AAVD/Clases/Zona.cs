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
    public class Zona
    {
        public int numeroZona { get; set; }
        public string municipio { get; set; }
        public Zona()
        {

        }

        public Zona(int numero, string municipio)
        {
            this.numeroZona = numero;
            this.municipio = municipio;
        }

        //BD QUERY
        public static Zona Buscar(string municipio)
        {
            Zona temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Zona>("sp_BuscarZona", new { @municipio = municipio }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
            }
            else
            {

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
                        @municipio = zona.municipio,
                        @numeroZona = zona.numeroZona
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {


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
                        @municipio = zona.municipio,
                        @numeroZona = zona.numeroZona
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }
        public static void Eliminar(string municipio)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Zona>("sp_EliminarZona",
                    new
                    {
                        @municipio = municipio
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

                var data = ConexionDB_MAD.db.Query<Zona>("sp_ConsultarZonas",
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
