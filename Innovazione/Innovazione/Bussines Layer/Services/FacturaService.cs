using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Innovazione.DataLayer;

namespace Innovazione.Bussines_Layer.Services
{
    public class FacturaService
    {
        private FacturaDao oFacturaDao;
        public FacturaService()
        {
            oFacturaDao = new FacturaDao();
        }

        public int calcularNumeroVenta()
        {
            return (oFacturaDao.numeroVenta());
        }
    }
}
