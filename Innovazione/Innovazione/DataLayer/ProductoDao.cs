using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innovazione.Bussines_Layer;
using Innovazione.DataLayer;
using System.Data;

namespace Innovazione.DataLayer
{
    public class ProductoDao
    {
        public IList<Producto> getAll()
        {
            List<Producto> lista = new List<Producto>();
            string sql = "Select p.* FROM Producto P WHERE P.estadoBajaProducto = 'S'";
            Producto oProducto = null;

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL(sql).Rows)
                lista.Add(mapUserProducto(row));

            return lista;
        }

        public IList<Producto> getByFilters(List<object> @params)
        {
            List<Producto> lista = new List<Producto>();
            string sql = "SELECT P.* from Producto WHERE P.estadoBajaProducto = 'S'";
            Producto oProducto = null;
            if (@params[0] != null)
                sql += " AND P.nombre LIKE '%' @param1 + '%' ";
            foreach (DataRow row in BDHelper.getBDHelper().consultarSQLConParametros(sql, @params).Rows)
                lista.Add(mapUserProducto(row));
            return lista;
        }

        public bool create(Producto oProducto)
        {
            string sql = "INSERT INTO Producto (nombre, descripcion, precio, cantDisponible, estadoBajaProducto) VALUES ('";
            sql += oProducto.nombre + "', '";
            sql += oProducto.descripcion + "','";
            sql += oProducto.precio.ToString() + "','";
            sql += oProducto.cantDisponible.ToString() + "','S')";

            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }

        public bool update(Producto oProducto)
        {
            string sql = "UPDATE Producto SET nombre='";
            sql += oProducto.nombre + "', descripcion='";
            sql += oProducto.descripcion + "', precio='";
            sql += oProducto.precio.ToString() + "', cantDisponible='";
            sql += oProducto.cantDisponible.ToString() + "', estadoBajaProducto='";
            sql += oProducto.estadoBajaProducto.ToString() + "'";
            sql += " WHERE idProducto = " + oProducto.idProducto.ToString();

            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }


        private Producto mapUserProducto (DataRow row)
        {
            Producto oProducto = new Producto();

            oProducto.idProducto = Convert.ToInt32(row["idProducto"].ToString());
            oProducto.nombre = row["nombre"].ToString();
            oProducto.descripcion = row["descripcion"].ToString();
            oProducto.precio = Convert.ToDouble(row["precio"].ToString());
            oProducto.cantDisponible = Convert.ToInt32(row["cantDisponible"].ToString());
            oProducto.estadoBajaProducto = Convert.ToChar(row["estadoBajaProducto"].ToString());

            return oProducto;
        }
    } 
}
