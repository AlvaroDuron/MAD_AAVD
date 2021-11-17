using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAVD
{
    class Usuario
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public bool empleado { get; set; }
        public byte estado { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nombre, string contraseña, bool empleado, byte estado)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.empleado = empleado;
            this.estado = estado;
        }

        //BD QUERY
        public static void Consulta()
        {

        }

        public static void Modifica()
        {

        }

        public static void Agrega()
        {

        }

        public static void Elimina()
        {

        }
    }
}
