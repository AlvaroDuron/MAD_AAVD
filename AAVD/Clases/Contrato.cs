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
    public class Contrato
    {
        public int numeroContrato { get; set; }
        public int numeroMedidor { get; set; }
        public string nombreUsuario { get; set; }
        public string tipoServicio { get; set; }
        public char categoria { get; set; }
        public int numeroExterior { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public byte estado { get; set; }
        public DateTime creacion { get; set; }
        public DateTime fechaAltaMod { get; set; }

        public Contrato()
        {

        }

        public Contrato(string nombreUsuario, int numeroContrato, int numeroMedidor, char categoria, string tipoServicio, int numeroExterior, string calle, string colonia, string municipio, byte estado, DateTime creacion, DateTime fechaAltaMod)
        {
            this.nombreUsuario = nombreUsuario;
            this.numeroContrato = numeroContrato;
            this.numeroMedidor = numeroMedidor;
            this.categoria = categoria;
            this.tipoServicio = tipoServicio;
            this.numeroExterior = numeroExterior;
            this.calle = calle;
            this.colonia = colonia;
            this.municipio = municipio;
            this.estado = estado;
            this.creacion = creacion;
            this.fechaAltaMod = fechaAltaMod;
        }

        //BD QUERY
        public static Contrato Buscar(int numeroContrato)
        {
            Contrato temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Contrato>("sp_BuscarContrato", new { @numeroContrato = numeroContrato }, commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT nombreUsuario, numeroContrato, numeroMedidor, categoria, tipoServicio, numeroExterior, calle, colonia, municipio, estado, creacion, fechaAtaMod " +
                "FROM Contrato WHERE numeroContrato = {0} allow filtering;",
                numeroContrato);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Contrato> data = mapper.Fetch<Contrato>(query);
                List<Contrato> lista = data.ToList();
                if (lista.Count() > 0)
                {
                    temp = lista.ToList()[0];
                }
            }
            return temp;
        }
        public static Contrato BuscarPorMedidor(int numeroMedidor)
        {
            Contrato temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Contrato>("sp_BuscarContratoPorMedidor", new { @numeroMedidor = numeroMedidor }, commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT nombreUsuario, numeroContrato, numeroMedidor, categoria, tipoServicio, numeroExterior, calle, colonia, municipio, estado, creacion, fechaAtaMod " +
                "FROM Contrato WHERE numeroMedidor = {0} allow filtering;",
                numeroMedidor);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Contrato> data = mapper.Fetch<Contrato>(query);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
            }
            return temp;
        }
        public static void Agregar(Contrato contrato)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Contrato>("sp_AgregarContrato",
                    new
                    {
                        //@numeroContrato = contrato.numeroContrato
                        @nombreUsuario = contrato.nombreUsuario,
                        @numeroMedidor = contrato.numeroMedidor,
                        @tipoServicio = contrato.tipoServicio,
                        @categoria = contrato.categoria,
                        @estado = contrato.estado,
                        @numeroExterior = contrato.numeroExterior,
                        @calle = contrato.calle,
                        @colonia = contrato.colonia,
                        @municipio = contrato.municipio
                        //@creacion = contrato.creacion,
                        //@fechaAltaMod = contrato.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO Contrato(numeroContrato, nombreUsuario, numeroMedidor, categoria, tipoServicio, numeroExterior, calle, colonia, municipio, estado, creacion, fechaAtaMod) " +
                    "VALUES({0}, '{1}', {2}, '{3}', '{4}', {5}, '{6}', '{7}', '{8}', {9}, '{10}', toUnixTimestamp(now()); ",
                    contrato.numeroContrato, contrato.nombreUsuario, contrato.numeroMedidor, contrato.categoria, contrato.tipoServicio, contrato.numeroExterior, contrato.calle, contrato.colonia, contrato.municipio, contrato.estado, contrato.creacion
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }
        public static void Modificar(Contrato contrato)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Contrato>("sp_ModificarContrato",
                    new
                    {
                        @numeroContrato = contrato.numeroContrato,
                        @nombreUsuario = contrato.nombreUsuario,
                        @numeroMedidor = contrato.numeroMedidor,
                        @categoria = contrato.categoria,
                        @tipoServicio = contrato.tipoServicio,
                        @numeroExterior = contrato.numeroExterior,
                        @calle = contrato.calle,
                        @colonia = contrato.colonia,
                        @municipio = contrato.municipio,
                        @estado = contrato.estado,
                        @creacion = contrato.creacion,
                        //@fechaAltaMod = contrato.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE Contrato SET nombreUsuario = '{1}', numeroMedidor = {2}, categoria = '{3}', tipoServicio = '{4}', numeroExterior = {5}, calle = '{6}', colonia = '{7}', municipio = '{8}', estado = '{9}', creacion = '{10}', fechaAltaMod = toUnixTimestamp(now()) " +
                    "WHERE numeroContrato = {0} if exists;",
                    contrato.numeroContrato, contrato.nombreUsuario, contrato.numeroMedidor, contrato.categoria, contrato.tipoServicio, contrato.numeroExterior, contrato.calle, contrato.colonia, contrato.municipio, contrato.estado, contrato.creacion
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }
        public static void Eliminar(int numeroContrato)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<Empleado>("sp_EliminarContrato", new { @numeroContrato = numeroContrato }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM Contrato WHERE numeroContrato = {0} if exists;",
                    numeroContrato
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

                var data = ConexionDB_MAD.db.Query<Contrato>("sp_ConsultarContratos",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT numeroContrato, nombreUsuario, numeroMedidor, categoria, tipoServicio, numeroExterior, calle, colonia, municipio, estado, creacion, fechaAtaMod " +
                "FROM Contrato allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Contrato> data = mapper.Fetch<Contrato>(query);
                dg.DataSource = data.ToList();
            }
        }
        public static void LlenarCB(ComboBox cb)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<string>("sp_ConsultarContratosPorMedidor",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                cb.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT numeroMedidor " +
                "FROM Contrato allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Contrato> data = mapper.Fetch<Contrato>(query);
                cb.DataSource = data.ToList();
            }
        }
    }
}
