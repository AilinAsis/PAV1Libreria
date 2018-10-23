using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovazione.Bussines_Layer
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int cantDisponible { get; set; }
        public char estadoBajaProducto { get; set; }
    }
}
