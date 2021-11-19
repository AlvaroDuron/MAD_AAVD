using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;
using Cassandra.Mapping;

namespace AAVD
{
    public class Contrato
    {
        public int numeroContrato { get; set; }
        public int numeroMedidor { get; set; }
        public string categoria { get; set; }
        public string tipoServicio { get; set; }
        public string estatus { get; set; }
        public string municipio { get; set; }
        public string domicilio { get; set; }
        public DateTime creacion { get; set; }
        public DateTime modificacion { get; set; }

        public Contrato()
        {

        }

        public Contrato(int numeroContrato, int numeroMedidor, string categoria, string tipoServicio, string estatus, string municipio, string domicilio, DateTime creacion, DateTime modificacion)
        {
            this.numeroContrato = numeroContrato;
            this.numeroMedidor = numeroMedidor;
            this.categoria = categoria;
            this.tipoServicio = tipoServicio;
            this.estatus = estatus;
            this.municipio = municipio;
            this.domicilio = domicilio;
            this.creacion = creacion;
            this.modificacion = modificacion;
        }

        //BD QUERY
        public static Contrato Buscar(int numeroContrato)
        {
            Contrato temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Contrato>("sp_BuscarContrato", new { @numeroContrato = numeroContrato }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
                
            }
            else
            {
                ConexionDB_AAVD cass = ConexionDB_AAVD.getInstance();
                IMapper mapper = ConexionDB_AAVD.conexion();
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
                        @numeroContrato = contrato.numeroContrato,
                        @numeroMedidor = contrato.numeroMedidor,
                        @categoria = contrato.categoria,
                        @tipoServicio = contrato.tipoServicio,
                        @estatus = contrato.estatus,
                        @municipio = contrato.municipio,
                        @domicilio = contrato.domicilio,
                        @creacion = contrato.creacion,
                        @modificacion = contrato.modificacion
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                ConexionDB_AAVD.agregar("INSERT INTO Contrato (numeroServicio, municipio, calle, numeroCalle, colonia, tipoServicio, estatus, numeroMedidor, categoria, curp, rfc) VALUES (" + Guid.NewGuid() + "'Guadalupe', 'Hierro', '336', 'Cristales', 'Domestico', 'Activo'," + Guid.NewGuid() + ", 'A', 'asdf', 'fgfgfgf');");
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
                        @numeroMedidor = contrato.numeroMedidor,
                        @categoria = contrato.categoria,
                        @tipoServicio = contrato.tipoServicio,
                        @estatus = contrato.estatus,
                        @municipio = contrato.municipio,
                        @domicilio = contrato.domicilio,
                        @creacion = contrato.creacion,
                        @modificacion = contrato.modificacion
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }
        public static void Eliminar(int id)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<Empleado>("sp_EliminarContrato", new { @numeroContrato = id }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }

        //FORM METODOS

    }
}
