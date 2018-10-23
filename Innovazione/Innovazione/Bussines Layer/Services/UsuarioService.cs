using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innovazione.DataLayer;

namespace Innovazione.Bussines_Layer.Services
{
    class UsuarioService
    {
        private UsuarioDao oUsuarioDao;

        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }

        public Usuario validarUsuario(string nombre, string password)
        {
            return oUsuarioDao.getUserByNamePass(nombre, password);
        }

        public Usuario validarNombreUsuario(string nombre)
        {
            return oUsuarioDao.getUserByName(nombre);
        }

        public IList<Usuario> consultarUsuariosConFiltros(List<object> @params)
        {
            return oUsuarioDao.getByFilters(@params);
        }

        public IList<Usuario> consultarUsuarios()
        {
            return oUsuarioDao.getAll();
        }
        
        /*public int consultarMaximoID()
        {
            return oUsuarioDao.maximoID();
        }*/

        public bool crearUsuario(Usuario oUsuario)
        {
            return oUsuarioDao.create(oUsuario);
        }

        public bool actualizarUsuario(Usuario oUsuario)
        {
            return oUsuarioDao.update(oUsuario);
        }

        public bool modificarEstadoUsuario(Usuario oUsuario)
        {
            return oUsuarioDao.update(oUsuario);
        }
    }
}
