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
                        @nombreUsuario = contrato.nombreUsuario,
                        //@numeroContrato = contrato.numeroContrato
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
                        @nombreUsuario = contrato.nombreUsuario,
                        @numeroContrato = contrato.numeroContrato,
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

            }
        }
    }
}
