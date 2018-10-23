using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innovazione.DataLayer;

namespace Innovazione.Bussines_Layer.Services
{
    class ClienteService
    {
        private ClienteDao oClienteDao;

        public ClienteService()
        {
            oClienteDao = new ClienteDao();
        }

        public Cliente verificarExistenciaCliente(string dni)
        {
            return oClienteDao.getClienteByDni(dni);
        }

        public IList<Cliente> allClientes()
        {
            return oClienteDao.getAllClientes();
        }

        public IList<Cliente> consultarUsuarioConFiltros(List<object> @params)
        {
            return oClienteDao.conFiltros(@params);
        }

        public bool create(Cliente oCliente)
        {
            return oClienteDao.create(oCliente);
        }

        public bool update (Cliente oCliente)
        {
            return oClienteDao.update(oCliente);
        }

        public bool delete(Cliente oCliente)
        {
            return oClienteDao.update(oCliente);
        }

    }
}
