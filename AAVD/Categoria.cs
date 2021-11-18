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
    public class Categoria
    {
        public char categoria;
        public float porcentaje;

        public Categoria()
        {

        }
        public Categoria(char categoria, float porcentaje)
        {
            this.categoria = categoria;
            this.porcentaje = porcentaje;
        }

        public static void Modificar(char categoria, float porcentaje)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Zona>("sp_ModificarCategoria",
                    new
                    {
                        @categoria = categoria,
                        @procentaje = porcentaje
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }
        public static void LlenarDG(DataGridView dg)
        {
            try
            {
                if (Program.MAD_AAVD)
                {
                    ConexionDB_MAD.conectar();

                    var data = ConexionDB_MAD.db.Query<Categoria>("sp_ConsultarCategorias",
                        new { },
                        commandType: CommandType.StoredProcedure);

                    ConexionDB_MAD.desconectar();

                    dg.DataSource = data.ToList();
                }
                else
                {

                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Error:" + except);
            }
        }
    }
}
