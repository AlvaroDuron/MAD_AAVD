using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAVD
{
    class Domicilio
    {
        public int numeroCalle { get; set; } 
        public int calle { get; set; }
        public int colonia { get; set; }
        public int municipio { get; set; }

        public Domicilio()
        {

        }
        public Domicilio(int numeroCalle, int calle, int colonia, int municipio)
        {
            this.numeroCalle = numeroCalle;
            this.calle = calle;
            this.colonia = colonia;
            this.municipio = municipio;
        }

        //DB QUERY


        //FORM METODOS

    }
    class Calle
    {
        public int id { get; set; }
        public string calle { get; set; }

        public Calle()
        {

        }
        public Calle(int id, string calle)
        {
            this.id = id;
            this.calle = calle;
        }

        //DB QUERY


        //FORM METODOS

    }
    class Colonia
    {
        public int id { get; set; }
        public string colonia { get; set; }

        public Colonia()
        {

        }
        public Colonia(int id, string colonia)
        {
            this.id = id;
            this.colonia = colonia;
        }

        //DB QUERY


        //FORM METODOS

    }
}
