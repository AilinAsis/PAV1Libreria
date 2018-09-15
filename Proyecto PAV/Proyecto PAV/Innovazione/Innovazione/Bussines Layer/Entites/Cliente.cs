using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovazione.Bussines_Layer
{
    class Cliente
    {
        public int nroDni { get; set; }
        public int idTipoDni { get; set; }
        public string descripcionTipoDni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
    }
}
