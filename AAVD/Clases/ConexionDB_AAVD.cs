using Cassandra;
using Cassandra.Mapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AAVD
{
    class ConexionDB_AAVD
    {
        static private string HostCQL { get; set; }
        static private string keyspace { get; set; }

        static private Cluster cluster;
        static private ISession session;

        static private ConexionDB_AAVD _instance = null;
        private ConexionDB_AAVD()
        {
            HostCQL = ConfigurationManager.AppSettings["HostCQL"].ToString();
            keyspace = ConfigurationManager.AppSettings["KeySpace"].ToString();
            cluster = Cluster.Builder().AddContactPoint(HostCQL).Build();
        }
        static public ConexionDB_AAVD getInstance()
        {
            if (_instance == null)
            {
                _instance = new ConexionDB_AAVD();
            }
            return _instance;
        }

        static public IMapper conexion()
        {
            session = cluster.Connect(keyspace);
            IMapper mapper = new Mapper(session);
            return mapper;
        }

        static public void executeQuery(string query)
        {
            session = cluster.Connect(keyspace);
            session.Execute(query);
        }

        //static public void pruebaConexion()
        //{
        //    string query = "select id, nick, pass, recordar, tipo from Administrador;";
        //    IMapper mapper = conexion();
        //    IEnumerable<Administrador> result = mapper.Fetch<Administrador>(query);
        //    List<Administrador> admins = result.ToList();
        //}
    }
}