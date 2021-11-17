using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;

namespace AAVD
{
    class ConexionDB_AAVD
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        private static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder().AddContactPoint(_dbServer).Build();
            _session = _cluster.Connect(_dbKeySpace);
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        public void Insertar()
        {

        }
    }
}
