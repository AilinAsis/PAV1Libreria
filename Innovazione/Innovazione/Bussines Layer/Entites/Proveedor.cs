using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovazione.Bussines_Layer
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string CUIL { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public char estadoBajaProveedor { get; set; }
    }
}
