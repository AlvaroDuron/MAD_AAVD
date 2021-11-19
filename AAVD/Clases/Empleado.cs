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
    public class Empleado
    {
        public Usuario usuario { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime nacimiento { get; set; }
        public string domicilio { get; set; }
        public bool genero { get; set; }
        public DateTime modificacion { get; set; }

        public Empleado()
        {

        }
        public Empleado(Usuario usuario, int id, string nombre, DateTime nacimiento, string domicilio, bool genero, DateTime modificacion)
        {
            this.usuario = usuario;
            this.id = id;
            this.nombre = nombre;
            this.nacimiento = nacimiento;
            this.domicilio = domicilio;
            this.genero = genero;
            this.modificacion = modificacion;
        }

        //BD QUERY
        public static Empleado Buscar(string nombreEmpleado)
        {
            Empleado temp = null;
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();
                var data = ConexionDB_MAD.db.Query<Empleado>("sp_BuscarEmpleado", new { @nombre = nombreEmpleado }, commandType: CommandType.StoredProcedure);
                temp = data.ToList()[0];
                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
            return temp;
        }
        public static void Agregar(Empleado empleado)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Empleado>("sp_AgregarEmpleado",
                    new
                    {
                        @idEmpleado = empleado.id,
                        @nombre = empleado.nombre,
                        @nacimiento = empleado.nacimiento,
                        @domicilio = empleado.domicilio,
                        @genero = empleado.genero,
                        @fechaAltaMod = empleado.modificacion
                    },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();
            }
            else
            {

            }
        }
        public static void Modificar(Empleado empleado)
        {
            if (Program.MAD_AAVD)
            {
                ConexionDB_MAD.conectar();

                ConexionDB_MAD.db.Query<Empleado>("sp_ModificarEmpleado",
                    new
                    {
                        @idEmpleado = empleado.id,
                        @nombre = empleado.nombre,
                        @nacimiento = empleado.nacimiento,
                        @domicilio = empleado.domicilio,
                        @genero = empleado.genero,
                        @fechaAltaMod = empleado.modificacion
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
                ConexionDB_MAD.db.Query<Empleado>("sp_EliminarEmpleado", new { @idEmpleado = id }, commandType: CommandType.StoredProcedure);
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

                var data = ConexionDB_MAD.db.Query<Empleado>("sp_ConsultarEmpleados",
                    new { },
                    commandType: CommandType.StoredProcedure);

                ConexionDB_MAD.desconectar();

                dg.DataSource = data.ToList();
            }
            else
            {

            }
        }
    }
}
