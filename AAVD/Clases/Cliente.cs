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
    public class ClienteFisico
    {
        public Usuario usuario { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string curp { get; set; }
        public DateTime nacimiento { get; set; }
        public bool genero { get; set; }
        public DateTime modificacion { get; set; }

        public ClienteFisico()
        {

        }
        public ClienteFisico(Usuario usuario, int id, string nombre, string email, string curp, DateTime nacimiento, bool genero, DateTime modificacion)
        {
            this.usuario = usuario;
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.curp = curp;
            this.nacimiento = nacimiento;
            this.genero = genero;
            this.modificacion = modificacion;
        }

        //BD QUERY
        public static ClienteFisico Buscar(string nombreCliente)
        {
            ClienteFisico temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<ClienteFisico>("sp_BuscarClienteFisico", new { @nombre = nombreCliente }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
            return temp;
        }
        public static void Agregar(ClienteFisico cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<ClienteFisico>("sp_AgregarClienteFisico",
                    new
                    {
                        @idCliente = cliente.id,
                        @nombre = cliente.nombre,
                        @email = cliente.email,
                        @curp = cliente.curp,
                        @nacimiento = cliente.nacimiento,
                        @genero = cliente.genero,
                        @fechaAltaMod = cliente.modificacion
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }
        public static void Modificar(ClienteFisico cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Empleado>("sp_ModificarClienteFisico",
                    new
                    {
                        @idCliente = cliente.id,
                        @nombre = cliente.nombre,
                        @email = cliente.email,
                        @curp = cliente.curp,
                        @nacimiento = cliente.nacimiento,
                        @genero = cliente.genero,
                        @fechaAltaMod = cliente.modificacion
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
                ConexionDB_MAD.db.Query<ClienteFisico>("sp_EliminarClienteFisico", new { @idCliente = id }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }

        //FORM METODOS

    }

    class ClienteMoral
    {
        public Usuario usuario { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public string rfc { get; set; }
        public string email { get; set; }
        public DateTime constitucion { get; set; }
        public DateTime modificacion { get; set; }

        public ClienteMoral()
        {

        }
        public ClienteMoral(Usuario usuario, int id, string nombre, string rfc, string email, DateTime constitucion, DateTime modificacion)
        {
            this.usuario = usuario;
            this.id = id;
            this.nombre = nombre;
            this.rfc = rfc;
            this.email = email;
            this.constitucion = constitucion;
            this.modificacion = modificacion;
        }

        //BD QUERY
        public static ClienteMoral Buscar(string nombreCliente)
        {
            ClienteMoral temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<ClienteMoral>("sp_BuscarClienteMoral", new { @nombre = nombreCliente }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
            return temp;
        }
        public static void Agregar(ClienteMoral cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<ClienteMoral>("sp_AgregarClienteMoral",
                    new
                    {
                        @idCliente = cliente.id,
                        @nombre = cliente.nombre,
                        @rfc = cliente.rfc,
                        @email = cliente.email,
                        @constitucion = cliente.constitucion,
                        @fechaAltaMod = cliente.modificacion
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }
        public static void Modificar(ClienteMoral cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<ClienteMoral>("sp_ModificarClienteMoral",
                    new
                    {
                        @idCliente = cliente.id,
                        @nombre = cliente.nombre,
                        @rfc = cliente.rfc,
                        @email = cliente.email,
                        @constitucion = cliente.constitucion,
                        @fechaAltaMod = cliente.modificacion
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
                ConexionDB_MAD.db.Query<ClienteMoral>("sp_EliminarClienteMoral", new { @idCliente = id }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }

        //FORM METODOS

    }
}
