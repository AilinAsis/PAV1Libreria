using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovazione.Bussines_Layer
{
    class Factura
    {
        public int idFactura { get; set; }
        public int nroDniCliente {get; set; }
        public int tipoDniCliente { get; set; }
        public string descripcionTipoDniCliente { get; set; }
        public DateTime fechaFactura { get; set; }
        public string pagado { get; set; }

        public List<DetalleFactura> detalleFactura { get; set; }

        public Factura()
        {
            detalleFactura = new List<DetalleFactura>();
        }

        public void addDetalleFactura (DetalleFactura oDetalleFactura)
        {
            detalleFactura.Add(oDetalleFactura);
        }
    }
}
