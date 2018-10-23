using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Innovazione

{
    public class BDHelper
    {

        enum ResultadoTransaccion
        {
            exito, fracaso 
        }

        enum tipoConexion
        {
            simple, transaccion 
        }
        private SqlConnection miConexion = new SqlConnection();
        private SqlCommand miComando = new SqlCommand();
        private SqlTransaction transacciones = null;
        private ResultadoTransaccion miEstado = ResultadoTransaccion.exito;
        private tipoConexion miTipo = tipoConexion.simple;
        private string stringConexion;
        private static BDHelper instance;

        private BDHelper()
        {
            stringConexion = "Data Source=DESKTOP-4LK2C0S\\SQLEXPRESS;Initial Catalog=InnovazioneNueva;Integrated Security=True";
        }

        public static BDHelper getBDHelper()
        {
            if (instance == null)
            {
                instance = new BDHelper();
            }
            return instance;
        }

        public void comandosReutilizar(SqlCommand comando, SqlConnection conexion, string sql)
        {
            conexion.ConnectionString = stringConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
        }

        public int ejecutarSQL(string sql)
        {
            //INSERT-UPDATE-DELETE;
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlTransaction transaccion = null;
            int rtdo = 0;

            try
            {
                comandosReutilizar(comando, conexion, sql);
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
                comandosReutilizar(comando, conexion, sql);

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
                comandosReutilizar(comando, conexion, sql);

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

        public void EjecutarSqlConTransaccion (string sql)
        {
            try
            {
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = sql;
                miComando.ExecuteNonQuery();
            }
            catch
            {
                miEstado = ResultadoTransaccion.fracaso;
            }
        }

        public void conectarConTransaccion()
        {
            miTipo = tipoConexion.transaccion;
            miEstado = ResultadoTransaccion.exito;
            miConexion.ConnectionString = stringConexion;
            miConexion.Open();
            transacciones = miConexion.BeginTransaction();
            miComando.Transaction = transacciones;
            miComando.Connection = miConexion;
        }

        public void desconectar()
        {
            if (miTipo == tipoConexion.transaccion)
            {
                if (miEstado == ResultadoTransaccion.exito)
                {
                    transacciones.Commit();
                    MessageBox.Show("La transaccion se realizo con exito...");
                }
                else
                {
                    transacciones.Rollback();
                    MessageBox.Show("La transaccion no pudo realizarse...");
                }
                miTipo = tipoConexion.simple;
            }

            if ((miConexion.State == ConnectionState.Open))
            {
                miConexion.Close();
            }

            miConexion.Dispose();
        }
    }
}