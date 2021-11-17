using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AAVD
{
    public class ConexionDB_MAD
    {
        static public SqlConnection con;
        static public IDbConnection db;

        static public void conectar()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["HydroLAN"].ConnectionString);
            if (db.State == ConnectionState.Closed)
                db.Open();
        }

        static public void desconectar()
        {
            db.Close();
        }
    }
}