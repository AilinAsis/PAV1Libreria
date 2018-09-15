using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovazione.Bussines_Layer
{
    class DetalleFactura
    {
        public int nroFactura { get; set; }
        public int idProducto {get; set; }
        public string nombreProducto { get; set; }
        public int cantidad { get; set; }
    }
}
