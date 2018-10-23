using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Innovazione.DataLayer
{
    public class FacturaDao
    {
        public int numeroVenta()
        {
            int numeroVenta = 0;
            string sql = "Select IDENT_CURRENT('Venta') as 'NumeroVenta'";
            DataTable oTabla;
            oTabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (oTabla.Rows.Count > 0)
            {
                numeroVenta = map(oTabla.Rows[0]) + 1;
            }
            return numeroVenta;

        }

        private int map (DataRow row)
        {
            int numero;
            numero = Convert.ToInt32(row["NumeroVenta"].ToString());
            return numero;
        }
    }
}
