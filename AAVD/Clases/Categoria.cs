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
    public class Categoria
    {
        public string categoria { get; set; }
        public float porcentaje { get; set; }

        public Categoria()
        {

        }
        public Categoria(string categoria, float porcentaje)
        {
            this.categoria = categoria;
            this.porcentaje = porcentaje;
        }

        //BD QUERY
        public static Categoria Buscar(string categoria)
        {
            Categoria temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Categoria>("sp_BuscarCategoria", new { @categoria = categoria }, commandType: CommandType.StoredProcedure);
                if (data.Count() > 0)
                {
                    temp = data.ToList()[0];
                }
                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                "SELECT categoria, porcentaje " +
                "FROM Categoria WHERE categoria = '{0}' allow filtering;",
                categoria);

                IMapper mapper = ConexionDB_AAVD.conexion();
                IEnumerable<Categoria> data = mapper.Fetch<Categoria>(query);
                List<Categoria> categorias = data.ToList();
                if (categorias.Count() > 0)
                {
                    temp = categorias.ToList()[0];
                }
            }
            return temp;
        }
        public static void Modificar(Categoria categoria)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Categoria>("sp_ModificarCategoria",
                    new
                    {
                        @categoria = categoria.categoria,
                        @porcentaje = categoria.porcentaje
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {
                string query = string.Format(
                    "UPDATE Categoria SET porcentaje = {1} " +
                    "WHERE categoria = '{0}' if exists;",
                    categoria.categoria, categoria.porcentaje
                );
                ConexionDB_AAVD.executeQuery(query);
            }
        }

        //FORM METODOS
        public static void LlenarDG(DataGridView dg)
        {
            try
            {
                if (Program.MAD_AAVD)
                {
                    ConexionDB_MAD.conectar();

                    var data = ConexionDB_MAD.db.Query<Categoria>("sp_ConsultarCategorias", new { }, commandType: CommandType.StoredProcedure);

                    ConexionDB_MAD.desconectar();

                    dg.DataSource = data.ToList();
                }
                else
                {
                    string query = string.Format(
                    "SELECT categoria, porcentaje " +
                    "FROM Categoria allow filtering;"
                    );

                    IMapper mapper = ConexionDB_AAVD.conexion();
                    IEnumerable<Categoria> data = mapper.Fetch<Categoria>(query);
                    dg.DataSource = data.ToList();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error:" + except);
            }
        }

        public static void LlenarCB(ComboBox cb)
        {
            try
            {
                if (Program.MAD_AAVD)
                {
                    ConexionDB_MAD.conectar();

                    var data = ConexionDB_MAD.db.Query<string>("sp_ConsultarCategoriasPorCategoria", new { }, commandType: CommandType.StoredProcedure);

                    ConexionDB_MAD.desconectar();

                    cb.DataSource = data.ToList();
                }
                else
                {
                    string query = string.Format(
                    "SELECT categoria, porcentaje " +
                    "FROM Categoria allow filtering;"
                    );

                    IMapper mapper = ConexionDB_AAVD.conexion();
                    IEnumerable<Categoria> data = mapper.Fetch<Categoria>(query);
                    List<Categoria> categorias = data.ToList();
                    cb.Items.Clear();
                    foreach (Categoria categoria in categorias)
                    {
                        cb.Items.Add(categoria.categoria);
                    }
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error:" + except);
            }
        }
    }
}
