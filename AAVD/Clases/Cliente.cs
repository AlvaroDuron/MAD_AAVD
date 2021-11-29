﻿using Dapper;
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
    public class ClienteFisico
    {
        public string curp { get; set; }
        public string nombreUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public LocalDate nacimiento { get; set; }
        public string genero { get; set; }
        public string email { get; set; }
        public DateTimeOffset fechaAltaMod { get; set; }

        public ClienteFisico()
        {

        }
        public ClienteFisico(string curp, string nombreUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, LocalDate nacimiento, string genero, string email, DateTimeOffset fechaAltaMod)
        {
            this.curp = curp;
            this.nombreUsuario = nombreUsuario;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.email = email;
            this.nacimiento = nacimiento;
            this.genero = genero;
            this.fechaAltaMod = fechaAltaMod;
        }

        //BD QUERY
        public static ClienteFisico Buscar(string curp)
        {
            ClienteFisico temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<ClienteFisico>("sp_BuscarClienteFisico", new { @curp = curp }, commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, email, fechaAltaMod " +
                "FROM ClienteFisico WHERE curp = '{0}' allow filtering;",
                curp);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<ClienteFisico> data = mapper.Fetch<ClienteFisico>(query);
                List<ClienteFisico> lista = data.ToList();
                if (lista.Count() > 0)
                {
                    temp = lista.ToList()[0];
                }
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
                        @curp = cliente.curp,
                        @nombreUsuario = cliente.nombreUsuario,
                        @nombre = cliente.nombre,
                        @apellidoPaterno = cliente.apellidoPaterno,
                        @apellidoMaterno = cliente.apellidoMaterno,
                        @nacimiento = cliente.nacimiento,
                        @genero = cliente.genero,
                        @email = cliente.email
                        //@fechaAltaMod = cliente.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO ClienteFisico(curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, email, fechaAltaMod) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', toUnixTimestamp(now())); ",
                    cliente.curp, cliente.nombreUsuario, cliente.nombre, cliente.apellidoPaterno, cliente.apellidoMaterno, cliente.nacimiento, cliente.genero, cliente.email
                );
                ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se agregó al cliente correctamente a la base de datos.", "Exito");
            }
        }
        public static void Modificar(ClienteFisico cliente)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<ClienteFisico>("sp_ModificarClienteFisico",
                    new
                    {
                        @curp = cliente.curp,
                        @nombreUsuario = cliente.nombreUsuario,
                        @nombre = cliente.nombre,
                        @apellidoPaterno = cliente.apellidoPaterno,
                        @apellidoMaterno = cliente.apellidoMaterno,
                        @nacimiento = cliente.nacimiento,
                        @genero = cliente.genero,
                        @email = cliente.email
                        //@fechaAltaMod = cliente.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE ClienteFisico SET nombre = '{1}', apellidoPaterno = '{2}', apellidoMaterno = '{3}', nacimiento = '{4}', genero = '{5}', email = '{6}', fechaAltaMod = toUnixTimestamp(now()) " +
                    "WHERE curp = '{0}' if exists;",
                    cliente.curp, cliente.nombre, cliente.apellidoPaterno, cliente.apellidoMaterno, cliente.nacimiento, cliente.genero, cliente.email
                );
                ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se modificó el cliente correctamente a la base de datos.", "Exito");
            }
        }
        public static void Eliminar(string curp)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<ClienteFisico>("sp_EliminarClienteFisico", new { @curp = curp }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM ClienteFisico WHERE curp = '{0}' if exists;",
                    curp
                    );
                ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se eliminó el cliente correctamente a la base de datos.", "Exito");
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<ClienteFisico>("sp_ConsultarClientesFisicos",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, email, fechaAltaMod " +
                "FROM ClienteFisico allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<ClienteFisico> data = mapper.Fetch<ClienteFisico>(query);
                dg.DataSource = data.ToList();
            }
        }

        public static void LlenarDGBan(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<ClienteFisico>("sp_ConsultarClientesFisicosBaneados",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                IMapper mapper = ConexionDB_AAVD.conexion();

                string query1 = string.Format(
                "SELECT nombreUsuario " +
                "FROM Usuario WHERE estado = 2 allow filtering;"
                );
                IEnumerable<Usuario> data = mapper.Fetch<Usuario>(query1);
                List<Usuario> usuarios = data.ToList();

                List<ClienteFisico> clientes = new List<ClienteFisico>();
                foreach (Usuario usuario in usuarios)
                {
                    string query2 = string.Format(
                    "SELECT curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, email, fechaAltaMod " +
                    "FROM ClienteFisico WHERE nombreUsuario = '{0}' allow filtering;",
                    usuario.nombreUsuario
                    );
                    IEnumerable<ClienteFisico> data2 = mapper.Fetch<ClienteFisico>(query2);
                    if (data2.Count() > 0)
                    {
                        clientes.Add(data2.ToList()[0]);
                    }
                }
                dg.DataSource = clientes.ToList();
            }
        }

        public static void LlenarCB(ComboBox cb)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<string>("sp_ConsultarClientesFisicosPorUsuario",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                cb.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT curp, nombreUsuario, nombre, apellidoPaterno, apellidoMaterno, nacimiento, genero, email, fechaAltaMod " +
                "FROM ClienteFisico allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<ClienteFisico> data = mapper.Fetch<ClienteFisico>(query);
                List<ClienteFisico> clientes = data.ToList();
                cb.Items.Clear();
                foreach (ClienteFisico cliente in clientes)
                {
                    cb.Items.Add(cliente.nombreUsuario);
                }
            }
        }
    }

    class ClienteMoral
    {
        public string rfc { get; set; }
        public string nombreUsuario { get; set; }
        public string nombre { get; set; }
        public LocalDate constitucion { get; set; }
        public string email { get; set; }
        public DateTimeOffset fechaAltaMod { get; set; }

        public ClienteMoral()
        {

        }
        public ClienteMoral(string rfc, string nombreUsuario, string nombre, LocalDate constitucion, string email, DateTimeOffset fechaAltaMod)
        {
            this.rfc = rfc;
            this.nombreUsuario = nombreUsuario;
            this.nombre = nombre;
            this.constitucion = constitucion;
            this.email = email;
            this.fechaAltaMod = fechaAltaMod;
        }

        //BD QUERY
        public static ClienteMoral Buscar(string rfc)
        {
            ClienteMoral temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<ClienteMoral>("sp_BuscarClienteMoral", new { @rfc = rfc }, commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod " +
                "FROM ClienteMoral WHERE rfc = '{0}' allow filtering;",
                rfc);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<ClienteMoral> data = mapper.Fetch<ClienteMoral>(query);
                List<ClienteMoral> lista = data.ToList();
                if (lista.Count() > 0)
                {
                    temp = lista.ToList()[0];
                }
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
                        @rfc = cliente.rfc,
                        @nombreUsuario = cliente.nombreUsuario,
                        @nombre = cliente.nombre,
                        @constitucion = cliente.constitucion,
                        @email = cliente.email
                        //@fechaAltaMod = cliente.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "INSERT INTO ClienteMoral(rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', toUnixTimestamp(now())); ",
                    cliente.rfc, cliente.nombreUsuario, cliente.nombre, cliente.constitucion, cliente.email
                );
                ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se agregó al cliente correctamente a la base de datos.", "Exito");
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
                        @rfc = cliente.rfc,
                        @nombreUsuario = cliente.nombreUsuario,
                        @nombre = cliente.nombre,
                        @constitucion = cliente.constitucion,
                        @email = cliente.email
                        //@fechaAltaMod = cliente.fechaAltaMod
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE ClienteMoral SET nombre = '{1}', constitucion = '{2}', email = '{3}', fechaAltaMod = toUnixTimestamp(now()) " +
                    "WHERE rfc = '{0}' if exists;",
                    cliente.rfc, cliente.nombre, cliente.constitucion, cliente.email
                );
                ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se modificó el cliente correctamente a la base de datos.", "Exito");
            }
        }
        public static void Eliminar(string rfc)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                ConexionDB_MAD.db.Query<ClienteMoral>("sp_EliminarClienteMoral", new { @rfc = rfc }, commandType: CommandType.StoredProcedure);
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "DELETE FROM ClienteMoral WHERE rfc = '{0}' if exists;",
                    rfc
                    );
                ConexionDB_AAVD.executeQuery(query);
                //MessageBox.Show("Se eliminó el cliente correctamente a la base de datos.", "Exito");
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<ClienteMoral>("sp_ConsultarClientesMorales",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod " +
                "FROM ClienteMoral allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<ClienteMoral> data = mapper.Fetch<ClienteMoral>(query);
                dg.DataSource = data.ToList();
            }
        }

        public static void LlenarDGBan(DataGridView dg)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<ClienteMoral>("sp_ConsultarClientesMoralesBaneados", new { }, commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod " +
                "FROM ClienteMoral WHERE estado = 2 allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();

                string query1 = string.Format(
                "SELECT nombreUsuario " +
                "FROM Usuario WHERE estado = 2 allow filtering;"
                );
                IEnumerable<Usuario> data = mapper.Fetch<Usuario>(query1);
                List<Usuario> usuarios = data.ToList();

                List<ClienteMoral> clientes = new List<ClienteMoral>();
                foreach (Usuario usuario in usuarios)
                {
                    string query2 = string.Format(
                    "SELECT rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod " +
                    "FROM ClienteMoral WHERE nombreUsuario = '{0}' allow filtering;",
                    usuario.nombreUsuario
                    );
                    IEnumerable<ClienteMoral> data2 = mapper.Fetch<ClienteMoral>(query2);
                    if (data2.Count() > 0)
                    {
                        clientes.Add(data2.ToList()[0]);
                    }
                }
                dg.DataSource = clientes.ToList();
            }
        }

        public static void LlenarCB(ComboBox cb)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                var data = ConexionDB_MAD.db.Query<string>("sp_ConsultarClientesMoralesPorUsuario",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                cb.DataSource = data.ToList();
            }
            else
            {
                string query = string.Format(
                "SELECT rfc, nombreUsuario, nombre, constitucion, email, fechaAltaMod " +
                "FROM ClienteMoral allow filtering;"
                );

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<ClienteMoral> data = mapper.Fetch<ClienteMoral>(query);
                List<ClienteMoral> clientes = data.ToList();
                cb.Items.Clear();
                foreach (ClienteMoral cliente in clientes)
                {
                    cb.Items.Add(cliente.nombreUsuario);
                }
            }
        }
    }
}
