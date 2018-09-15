using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Innovazione

{
    public class BDHelper
    {
        private string stringConexion;
        private static BDHelper instance;

        private BDHelper()
        {
            stringConexion = "Data Source=DESKTOP-4LK2C0S\\SQLEXPRESS;Initial Catalog=Innovazione;Integrated Security=True";
        }

        public static BDHelper getBDHelper()
        {
            if (instance == null)
            {
                instance = new BDHelper();
            }
            return instance;
        }

        public int ejecutarSQL(string sql)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlTransaction transaccion = null;
            int rtdo = 0;

            try
            {
                conexion.ConnectionString = stringConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;

                rtdo = comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }
            return rtdo;
        }

        public DataTable ConsultaSQL(string sql)
        {
            //Consulta simple
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                conexion.ConnectionString = stringConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                tabla.Load(comando.ExecuteReader()); //Cargar la tabla
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }

        }
        public DataTable consultarSQLConParametros(string sql, List<object> sqlParam)
        {
            //Con parámetros recibidos desde consola
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                conexion.ConnectionString = stringConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                var indice = 0;
                foreach (var param in sqlParam)
                {
                    if (param != null)
                    {
                        var n_param = "param" + Convert.ToString(indice + 1);
                        comando.Parameters.AddWithValue(n_param, param);
                    }
                    indice++;
                }

                tabla.Load(comando.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }

        }
    }
}