using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innovazione.Bussines_Layer;
using System.Data;

namespace Innovazione.DataLayer
{
    public class ProveedorDao
    {
        public Proveedor getByCUIL(string CUIL)
        {
            string sql = "SELECT P.* from Proveedor P WHERE CUIL=" + CUIL;
            DataTable tabla;
            Proveedor oProveedor = null;
            tabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (tabla.Rows.Count > 0)
            {
                oProveedor = mapProveedor(tabla.Rows[0]);
            }
            return oProveedor;
        }

        public IList<Proveedor> getAll()
        {
            List<Proveedor> lista = new List<Proveedor>();
            string sql = "SELECT P.* from Proveedor P WHERE P.estadoBajaProveedor = 'S'";
            Proveedor oProveedor = null;
            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL(sql).Rows)
                lista.Add(mapProveedor(row));
            return lista;
        }

        public IList<Proveedor> getByFiltros(List<object> @params)
        {
            List<Proveedor> lista = new List<Proveedor>();
            string sql = "SELECT P.* from Proveedor P WHERE P.estadoBajaProveedor = 'S'";
            Proveedor oProveedor = null;
            if (@params[0] != null)
                sql += " AND P.CUIL=@param1";
            if (@params[1] != null)
                sql += " AND P.nombre LIKE '%' + @param2 + '%'";
            if (@params[2] != null)
                sql += " AND p.apellido LIKE '%' + @param3 + '%'";

            foreach (DataRow row in BDHelper.getBDHelper().consultarSQLConParametros(sql, @params).Rows)
                lista.Add(mapProveedor(row));

            return lista;

        }

        public bool create(Proveedor oProveedor)
        {
            string sql = "INSERT INTO Proveedor (CUIL, nombre, apellido, estadoBajaProveedor) VALUES ('";
            sql += oProveedor.CUIL + "','";
            sql += oProveedor.nombre + "','";
            sql += oProveedor.apellido + "','S')";

            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }

        public bool update (Proveedor oProveedor)
        {
            string sql = "UPDATE Proveedor SET CUIL='";
            sql += oProveedor.CUIL + "', nombre='";
            sql += oProveedor.nombre + "', apellido='";
            sql += oProveedor.apellido + "', estadoBajaProveedor='";
            sql += oProveedor.estadoBajaProveedor.ToString() + "'";

            sql += " WHERE idProveedor = " + oProveedor.idProveedor.ToString();

            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }


        private Proveedor mapProveedor(DataRow row)
        {
            Proveedor oProveedor = new Proveedor();
            oProveedor.idProveedor = Convert.ToInt32(row["idProveedor"].ToString());
            oProveedor.nombre = row["nombre"].ToString();
            oProveedor.apellido = row["apellido"].ToString();
            oProveedor.CUIL = row["CUIL"].ToString();
            oProveedor.estadoBajaProveedor= Convert.ToChar(row["estadoBajaProveedor"].ToString());

            return oProveedor;
        }
    }
}
