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
        public static void LlenarDG(DataGridView dg)
        {
            ConexionDB_MAD.conectar();

            var data = ConexionDB_MAD.db.Query<Zona>("sp_ConsultarZonas",
                new { },
                commandType: CommandType.StoredProcedure);

            ConexionDB_MAD.desconectar();

            dg.DataSource = data.ToList();
        }
        public static void Modifica(int numero, string municipio)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Zona>("sp_ModificarZona",
                    new
                    {
                        @municipio = municipio,
                        @numeroZona = numero
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {


            }
        }
        public static void Agrega(int numero, string municipio)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Zona>("sp_AgregarZona",
                    new 
                    { 
                        @municipio = municipio,
                        @numeroZona = numero
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {


            }
        }
        public static void Elimina(string municipio)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<Zona>("sp_EliminarZona",
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
        //public static List<string> getMunicipios()
        //{
        //    ConexionDB_MAD.conectar();

        //    var data = ConexionDB_MAD.db.Query<string>("sp_ObtenerMunicipios",
        //        new { },
        //        commandType: CommandType.StoredProcedure);

        //    ConexionDB_MAD.desconectar();

        //    return data.ToList();
        //}
    }
}
