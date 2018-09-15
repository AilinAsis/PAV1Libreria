using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovazione.Bussines_Layer
{
    class Egreso
    {
        public int idEgreso { get; set; }
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public DateTime fechaEgreso { get; set; }
        public DateTime fechaEntrega { get; set; }
        public string compra { get; set; }
        public int idEstado { get; set; }
        public string nombreEstado { get; set; }

        public List<DetalleCompra> detalleCompra { get; set; }

        public Egreso()
        {
            detalleCompra = new List<DetalleCompra>();
        }

        public void addDetalleCompra (DetalleCompra oDetalleCompra)
        {
            detalleCompra.Add(oDetalleCompra);
        }
    }
}
