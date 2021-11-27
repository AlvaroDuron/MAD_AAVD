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
    class Domicilio
    {
        public int numeroCalle { get; set; } 
        public int calle { get; set; }
        public int colonia { get; set; }
        public int municipio { get; set; }

        public Domicilio()
        {

        }
        public Domicilio(int numeroCalle, int calle, int colonia, int municipio)
        {
            this.numeroCalle = numeroCalle;
            this.calle = calle;
            this.colonia = colonia;
            this.municipio = municipio;
        }

        //DB QUERY


        //FORM METODOS

    }
    class Calle
    {
        public int id { get; set; }
        public string calle { get; set; }

        public Calle()
        {

        }
        public Calle(int id, string calle)
        {
            this.id = id;
            this.calle = calle;
        }

        //DB QUERY


        //FORM METODOS

    }
    class Colonia
    {
        public int id { get; set; }
        public string colonia { get; set; }

        public Colonia()
        {

        }
        public Colonia(int id, string colonia)
        {
            this.id = id;
            this.colonia = colonia;
        }

        //DB QUERY


        //FORM METODOS

    }

    public class Municipio
    {
        public string municipio { get; set; }
        public int numeroZona { get; set; }

        public Municipio()
        {

        }
        public Municipio(string municipio, int numeroZona)
        {
            this.municipio = municipio;
            this.numeroZona = numeroZona;
        }

        //BD QUERY
        public static Municipio Buscar(string municipio)
        {
            Municipio temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Municipio>("sp_BuscarMunicipio", new { @municipio = municipio }, commandType: CommandType.StoredProcedure);
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
        public static void Agregar(Municipio municipio)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Municipio>("sp_AgregarMunicipio",
                    new
                    {
                        @municipio = municipio.municipio,
                        @numeroZona = municipio.numeroZona
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {


            }
        }
        public static void Modificar(Municipio municipio)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Municipio>("sp_ModificarMunicipio",
                    new
                    {
                        @municipio = municipio.municipio,
                        @numeroZona = municipio.numeroZona
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

                ConexionDB_MAD.db.Query<Municipio>("sp_EliminarMunicipio",
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

                var data = ConexionDB_MAD.db.Query<Municipio>("sp_ConsultarMunicipiosZonas",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {

            }
        }

        public static void LlenarCB(ComboBox cb)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<string>("sp_ConsultarMunicipiosPorNombre",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                cb.DataSource = data.ToList();
            }
            else
            {

            }
        }
    }
}
