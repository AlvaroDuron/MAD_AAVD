using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD.Clases
{
    class Recibo
    {
        public string nombreUsuario { get; set; }
        public string direccion { get; set; }
        public int numeroContrato { get; set; }
        public DateTime vencimiento { get; set; }
        public int mes { get; set; }
        public string expedicion { get; set; }
        public string numeroZona { get; set; }
        public string categoria { get; set; }
        public string tipoServicio { get; set; }
        public string numeroMedidor { get; set; }
    }
}
