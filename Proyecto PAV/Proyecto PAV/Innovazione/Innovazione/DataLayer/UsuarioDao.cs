using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Innovazione.Bussines_Layer;

namespace Innovazione.DataLayer
{
    class UsuarioDao
    {
        // Permite recuperar un usuario a partir de un nombre y password
        public Usuario getUserByNamePass(string nombre, string password)
        {
            string sql = "Select x.* from usuario x where x.nomUser = '" + nombre + "' AND contraseña = '" + password + "' AND x.activo = 'S'";
            DataTable oTabla;
            Usuario oUsuario = null/* TODO Change to default(_) if this is not a reference type */;

            oTabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (oTabla.Rows.Count > 0)
                oUsuario = map_user(oTabla.Rows[0]);

            return oUsuario;
        }

        

        public Usuario getUserByName(string nombre)
        {
            string sql = "Select x.* from usuario x where x.nomUser = '" + nombre + "'";
            DataTable oTabla;
            Usuario oUsuario = null/* TODO Change to default(_) if this is not a reference type */;

            oTabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (oTabla.Rows.Count > 0)
                oUsuario = map_user(oTabla.Rows[0]);

            return oUsuario;
        }



        // Permite recuperar todos los usuarios cargados
        public IList<Usuario> getAll()
        {
            List<Usuario> lst = new List<Usuario>();
            string sql = "Select x.* from usuario x";
            Usuario oUsuario = null/* TODO Change to default(_) if this is not a reference type */;

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL(sql).Rows)
                lst.Add(map_user(row));

            return lst;
        }


        public IList<Usuario> getByFilters(List<object> @params)
        {
            List<Usuario> lista = new List<Usuario>();
            string sql = "SELECT u.* from usuario u where ";
            Usuario oUsuario = null;

            if (@params[0] != null)
            {
                sql += "u.nomUser LIKE '%' + @param1 + '%'";
            }
            if (@params[1] != null)
            {
                if (@params[0] == null)
                {
                    sql += " u.activo LIKE @param2";
                }
                else
                {
                    sql += " AND u.activo LIKE @param2";
                }
               
            }

            foreach (DataRow row in BDHelper.getBDHelper().consultarSQLConParametros(sql, @params).Rows)
                lista.Add(map_user(row));

            return lista;
        }

        // Funciones CRUD
        public bool create(Usuario oUsuario)
        {
            string sql;

            sql = "INSERT INTO usuario (idUsuario, nomUser, contraseña, activo) VALUES('";
            sql += oUsuario.idUsuario + "','";
            sql += oUsuario.nomUser + "','";
            sql += oUsuario.contraseña + "','S')";

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }
        // Funciones CRUD

        public bool update(Usuario oUsuario)
        {
            string sql;

            sql = "UPDATE usuario SET nomUser = '";
            sql += oUsuario.nomUser + "', contraseña = '";
            sql += oUsuario.contraseña + "', activo = '";
            sql += oUsuario.activo + "'";   

            sql += " WHERE idUsuario = " + oUsuario.idUsuario.ToString();

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (BDHelper.getBDHelper().ejecutarSQL(sql) == 1);
        }

        // Función auxiliar responsable de MAPPEAR una fila de Users a un objeto Usuario
        private Usuario map_user(DataRow row)
        {
            Usuario oUsuario = new Usuario();

            oUsuario.idUsuario = Convert.ToInt32(row["idUsuario"].ToString());
            oUsuario.nomUser = row["nomUser"].ToString();
            oUsuario.contraseña = row["contraseña"].ToString();
            oUsuario.activo = row["activo"].ToString();
            return oUsuario;
        }
    }
}
    
