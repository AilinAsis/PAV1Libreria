using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Innovazione.Bussines_Layer;

namespace Innovazione.DataLayer
{
    class ClienteDao
    {

        //Verificar si un Cliente ya existe
        public Cliente getClienteByDni (string dni)
        {
            string sql = "SELECT C.*, T.descripcion, T.idTipoDni as id_TipoDni from Cliente C, TipoDni T WHERE C.tipoDni = T.idTipoDni AND C.nroDni=" + dni;
            DataTable tabla;
            Cliente oCliente = null;

            tabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (tabla.Rows.Count > 0)
            {
                oCliente = mapUser(tabla.Rows[0]);
            }
            return oCliente;
        }

        //Recuperar todos los clientes
        public IList<Cliente> getAllClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            string sql = "SELECT C.*, T.descripcion, T.idTipoDni as id_TipoDni from Cliente C, TipoDni T WHERE C.tipoDni=T.idTipoDni AND C.estadoBajaCliente = 'S'";
            Cliente oCliente = null;

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL(sql).Rows)
                lista.Add(mapUser(row));

            return lista;
        }

        //Con parámetros
        public IList<Cliente> conFiltros (List<object> @params)
        {
            List<Cliente> lista = new List<Cliente>();
            string Sql = "SELECT C.*, T.idTipoDni as t, T.descripcion from Cliente C, TipoDni T WHERE T.idTipoDni = C.TipoDni AND C.estadoBajaCliente = 'S'";
            Usuario oUsuario = null;

            if (@params[0] != null)
                Sql += " AND C.tipoDni = @param1";
            if (@params[1] != null)
                Sql += " AND C.nroDni = @param2";
            if (@params[2] != null)
                Sql += " AND C.nombre LIKE '%' + @param3 + '%'";
            if (@params[3] != null)
                Sql += " AND C.apellido LIKE '%' + @param4 + '%'";

            foreach (DataRow row in BDHelper.getBDHelper().consultarSQLConParametros(Sql, @params).Rows)
                lista.Add(mapUser(row));

            return lista;
        }

        //Funciones CRUD
        public bool create(Cliente oCliente)
        {
            string sql = "INSERT INTO Cliente (nroDni, tipoDni, apellido, nombre, mail, telefono, estadoBajaCliente) VALUES ('";
            sql += oCliente.nroDni.ToString() + "','";
            sql += oCliente.idTipoDni.ToString() + "','";
            sql += oCliente.apellido + "','";
            sql += oCliente.nombre + "','";
            sql += oCliente.mail + "','";
            sql += oCliente.telefono + "', 'S')";

            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }

        public bool update (Cliente oCliente)
        {
            string sql = "UPDATE Cliente SET nroDni ='";
            sql += oCliente.nroDni.ToString() + "', tipoDni='";
            sql += oCliente.idTipoDni.ToString() + "', nombre='";
            sql += oCliente.nombre + "', apellido = '";
            sql += oCliente.apellido + "', mail = '";
            sql += oCliente.mail + "', telefono = '";
            sql += oCliente.telefono + "', estadoBajaCliente = '";
            sql += oCliente.estadoBajaCliente + "'";
            sql += " WHERE idCliente = " + oCliente.idCliente.ToString();

            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }

        public bool delete (Cliente oCliente)
        {
            string sql = "DELETE FROM Cliente WHERE nroDni = " + oCliente.nroDni.ToString() + " AND tipoDni = " + oCliente.idTipoDni.ToString();
            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }
    
        private Cliente mapUser (DataRow row)
        {
            Cliente oCliente = new Cliente();
            oCliente.idCliente = Convert.ToInt32(row["idCliente"].ToString());
            oCliente.nroDni = Convert.ToInt32(row["nroDni"].ToString());
            oCliente.idTipoDni = Convert.ToInt32(row["tipoDni"].ToString());
            oCliente.descripcionTipoDni = row["descripcion"].ToString();
            oCliente.apellido = row["apellido"].ToString();
            oCliente.nombre = row["nombre"].ToString();
            oCliente.mail = row["mail"].ToString();
            oCliente.telefono = row["telefono"].ToString();
            oCliente.estadoBajaCliente = Convert.ToChar(row["estadoBajaCliente"].ToString());
            return oCliente;
        }
    }
}
