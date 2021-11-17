﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAVD
{
    class ClienteFisico
    {
        public Usuario usuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string genero { get; set; }
        public string email { get; set; }
        public string curp { get; set; }
        public DateTime nacimiento { get; set; }
        public DateTime modificacion { get; set; }

        public ClienteFisico()
        {

        }

        public ClienteFisico(string nombre, string contraseña, bool empleado, byte estado)
        {
            this.nombre = nombre;
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

    class ClienteMoral
    {
        public Usuario usuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string email { get; set; }
        public string rfc { get; set; }
        public DateTime constitucion { get; set; }
        public DateTime modificacion { get; set; }

        public ClienteMoral()
        {

        }

        public ClienteMoral(Usuario usuario, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string rfc, DateTime constitucion, DateTime modificacion)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.email = email;
            this.rfc = rfc;
            this.constitucion = constitucion;
            this.modificacion = modificacion;
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
