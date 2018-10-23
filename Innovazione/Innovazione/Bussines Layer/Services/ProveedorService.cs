using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innovazione.DataLayer;

namespace Innovazione.Bussines_Layer.Services
{
    public class ProveedorService
    {
        private ProveedorDao oProveedorDao;

        public ProveedorService()
        {
            oProveedorDao = new ProveedorDao();
        }

        public Proveedor validarProveedor(string CUIL)
        {
            return oProveedorDao.getByCUIL(CUIL);
        }

        public IList<Proveedor> getAll()
        {
            return oProveedorDao.getAll();
        }

        public IList<Proveedor> consultaConFiltros(List <object> @params)
        {
            return oProveedorDao.getByFiltros(@params);
        }

        public bool crearProveedor (Proveedor oProveedor)
        {
            return oProveedorDao.create(oProveedor);
        }

        public bool actualizarProveedor (Proveedor oProveedor)
        {
            return oProveedorDao.update(oProveedor);
        }
    }
}
