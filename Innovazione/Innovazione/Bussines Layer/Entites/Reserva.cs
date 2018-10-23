using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovazione.Bussines_Layer
{
    public class Reserva
    {
        public int idReserva { get; set; }
        public int nroDni { get; set; }
        public int idTipoDni { get; set; }
        public string descripcionTipoDni { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int idEstado { get; set; }
        public string descripcionEstado { get; set; }
        public float precioManoObra { get; set; }
        public int idFactura { get; set; }
        public float senia { get; set; }

    }
}
